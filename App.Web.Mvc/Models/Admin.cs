using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Models
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
