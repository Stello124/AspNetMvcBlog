using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AdminHomeControl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
