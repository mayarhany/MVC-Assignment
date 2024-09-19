using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Password is required")]
        //[RegularExpression(@"^(?=(.*[a-z]))(?=(.*[A-Z]))(?=(.*\d))(?=(.*\W))(?=(.*[^\s]).{6,})(?!(.*(.).*\1{2}))$",
        //ErrorMessage = "Password must be at least 6 characters long, with at least one lowercase letter, one uppercase letter, one digit, one non-alphanumeric character, and at least two unique characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare(nameof(Password), ErrorMessage = "confirm password does not matcj password")]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
        public string Token { get; set; }
    }
}
