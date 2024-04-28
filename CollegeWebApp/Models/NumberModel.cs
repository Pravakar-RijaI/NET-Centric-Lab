using System.ComponentModel.DataAnnotations;

namespace CollegeWebApp.Models
{
    public class NumberModel
    {
        [Range(-500,500)]
        public int FirstNumber { get; set; }
        [Range(-500,500)]
        public int SecondNumber { get; set; }
        public int Result { get; set; }
    }
}
