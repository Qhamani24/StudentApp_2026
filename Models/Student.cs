using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    
namespace StudentApp_2026.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string StudentNumber { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Faculty { get; set; }
    }
        
}
