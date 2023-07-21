using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class AdminCategoryControl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
