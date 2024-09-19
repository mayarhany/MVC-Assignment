using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Helper
{
	public static class EmailSettings
	{
		public static void SendEmail(Email input)
		{
			var client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;

			client.Credentials = new NetworkCredential("mayarhany604@gmail.com", "ayqnaigyzbxukenw");

			client.Send("mayarhany604@gmail.com", input.To, input.Subject, input.Body);
		}
	}
}
