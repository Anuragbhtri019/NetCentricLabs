using System.ComponentModel.DataAnnotations;

namespace WebApp7ByAnurag.Models
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public required  string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public  required string Password { get; set; }

        [DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm Password")]
        public required string ConfirmPassword { get; set; }
    }
}
