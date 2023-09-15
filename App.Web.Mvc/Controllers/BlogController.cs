using AspNetMvcBlog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcBlog.Controllers
{
    public class BlogController : Controller
    {


            private readonly AppDbContext _db;


            public BlogController(AppDbContext db)
            {
                _db = db;
            }

            public IActionResult Search(string query, int page)
            {
                return View();
            }

            public IActionResult Detail(int Id)
            {
                if (Id == 0)
                    return RedirectToAction(nameof(Index));

                var posts = _db.Post.Where(p => p.Id == Id).Include(p => p.PostImage).Include(p => p.CategoryPosts).ThenInclude(p => p.Category);

                if (posts is null)
                    return RedirectToAction(nameof(Index));

                return View(posts);


            }

        }
    }