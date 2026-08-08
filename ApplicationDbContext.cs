using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using StudentApp_2026.Models;

// Create a new class called ApplicationDbContext that inherits from DbContext. This class will be used to interact with the database.	
namespace StudentApp_2026.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<Student> Students { get; set; }
	}
}
