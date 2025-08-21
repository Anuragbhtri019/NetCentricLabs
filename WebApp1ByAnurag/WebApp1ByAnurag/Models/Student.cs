using System.ComponentModel.DataAnnotations;

namespace WebApp1ByAnurag.Models
{
    public class Student
    {
        [Required]
        public int StdID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Faculty is required")]
        [StringLength(50)]
        public string Faculty { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

    }
}
