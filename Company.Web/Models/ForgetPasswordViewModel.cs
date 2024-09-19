using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
	public class ForgetPasswordViewModel
	{
		[EmailAddress(ErrorMessage = "Invalid Email Format")]
		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }
	}
}
