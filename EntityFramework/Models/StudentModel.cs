using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        
        public string? Name { get; set; }
        
        public string? Field { get; set; }
        
        public int Semester { get; set; }
        
        public float Marks { get; set; }
    }
}
