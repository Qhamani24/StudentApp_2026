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
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Your Last name is required")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Your Student Number is required")]
        public required string StudentNumber { get; set; }

        [Required(ErrorMessage = "Your Gender is required")]
        public required string Gender { get; set; }

        [Required(ErrorMessage ="Your Faculty is required")]
        public required string Faculty { get; set; }
    }
        
}
