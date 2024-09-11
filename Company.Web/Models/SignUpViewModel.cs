using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=(.*[a-z]))(?=(.*[A-Z]))(?=(.*\d))(?=(.*\W))(?=(.*[^\s]).{6,})(?!(.*(.).*\1{2}))$",
        ErrorMessage = "Password must be at least 6 characters long, with at least one lowercase letter, one uppercase letter, one digit, one non-alphanumeric character, and at least two unique characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare(nameof(Password), ErrorMessage = "confirm password does not matcj password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Required to agree")]
        public bool IsAgree { get; set; }
    }
}
