using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
	public class LoginViewModel
	{
		[EmailAddress(ErrorMessage = "Invalid Email Format")]
		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}
