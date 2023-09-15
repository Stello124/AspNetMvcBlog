using AspNetMvcBlog.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class PageController : Controller
    {
        private readonly AppDbContext _db;

        public PageController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Detail(int Id)
        {
            if (Id == 0)
                return RedirectToAction(nameof(Index));

            var pages = _db.Page.Where(p => p.Id == Id);

            if (pages is null)
                return RedirectToAction(nameof(Index));

            return View(pages);
        }
    }
}