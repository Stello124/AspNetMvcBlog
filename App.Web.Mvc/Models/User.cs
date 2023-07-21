using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Models
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
