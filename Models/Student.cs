using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    
namespace StudentApp_2026.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Your Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Your Student Number is required")]
        public string StudentNumber { get; set; }

        [Required(ErrorMessage = "Your Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Your Faculty is required")]
        public string Faculty { get; set; }
    }
        
}
