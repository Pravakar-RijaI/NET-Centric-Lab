using System.ComponentModel.DataAnnotations;

namespace CollegeWebApp.Models
{
    public class StudentModel
    {
        public int SchoolId { get; set; } = 0;

        [Required]
        [Range(0,500)]
        public int RegistrationNumber { get; set; } = 0;
        
        [Required]
        [StringLength(50,MinimumLength =10)]
        public string Name { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
    }
}
