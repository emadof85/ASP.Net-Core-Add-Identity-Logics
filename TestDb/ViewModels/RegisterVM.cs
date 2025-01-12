using System.ComponentModel.DataAnnotations;

namespace TestDb.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Passwords don't match")]
        public string? ConfirmPassword { get; set; }
        public string? Address { get; set; }
    }
}
