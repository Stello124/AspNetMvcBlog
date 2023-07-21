using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AdminUserControl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
