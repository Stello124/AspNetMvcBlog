using AspNetMvcBlog.Data;
using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public NavbarViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
             
            NavbarViewModel result = new NavbarViewModel();
            result.Categories = _db.Category.ToList();
            result.Pages = _db.Page.ToList();

            return View(result);
        }
    }
} 