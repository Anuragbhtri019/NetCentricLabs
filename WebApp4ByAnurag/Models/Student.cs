using System.ComponentModel.DataAnnotations;

namespace WebApp4ByAnurag.Models
{
    public class Student
    {
        [Key]
        [Required(ErrorMessage = "This  is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "This  is required")]
        [StringLength(100, ErrorMessage = "Name is required.")]

        public string Name { get; set; }
        [Required(ErrorMessage = "This  is required")]
        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100.")]
        public double Marks { get; set; }
    }
}
