using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class BlogControl : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
    }
}
