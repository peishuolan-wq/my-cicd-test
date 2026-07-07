using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class AuthController1 : Controller
	{

		/// <summary>
		///註冊新會員
		///</summary
		///<remarks></remarks>

		public IActionResult Register()
		{
			return View();
		}
	}

	public class RegisterViewModel
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
	    
		public string Name { get; set; }
	}
}
