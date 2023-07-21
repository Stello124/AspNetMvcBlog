using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AdminPageControl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
