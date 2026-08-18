using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using StudentApp_2026.Models;
using StudentApp_2026.Views.Services;
using Microsoft.EntityFrameworkCore;


namespace StudentApp_2026.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Read - Get all students
        public  async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync(); // Use ToListAsync() for asynchronous operation, other tasks can happen while waiting for the database operation to complete.
            return View(students);
        }

        // Create: add new students
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student); // redisplay form with validation errors
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student); // redisplay form with validation errors
        }

        // DELETE: Remove student
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
