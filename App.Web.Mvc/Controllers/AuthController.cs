using AspNetMvcBlog.Data.Entity;
using AspNetMvcBlog.Data;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;

namespace AspNetMvcBlog.Controllers
{
	public class AuthController : Controller
	{

		private readonly AppDbContext _db;
		public AuthController(AppDbContext db)
		{
			_db = db;
		}

		public IActionResult Register()
		{
			User user = new User();

			return View(user);
		}

		[HttpPost]
		public IActionResult Register(User user)
		{
			if (user == null)
			{
				return View();
			}
            if (string.IsNullOrEmpty(user.UserNick) || string.IsNullOrEmpty(user.UserPassword))
            {
                ModelState.AddModelError("", "Kullanıcı Nickname ve şifre boş geçilemez.");
            }
            if (ModelState.IsValid)
			{
                user.UserPassword = ComputeSha256Hash(user.UserPassword);
                _db.User.Add(user);
				_db.SaveChanges();
				return RedirectToAction("Index", "Home");
			}

			return View(user);
		}
        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public IActionResult Login(string redirectUrl)
		{
			return View();
		}
		public IActionResult ForgotPassword()
		{
			return View();
		}

	}
}