using AspNetMvcBlog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcBlog.Controllers
{
		public class CategoryController : Controller
		{

			private readonly AppDbContext _db;


			public CategoryController(AppDbContext db)
			{
				_db = db;
			}

			public IActionResult Index(int id, int page)
			{
				return View();
			}
			public IActionResult Search(string searchString)
			{
				if (searchString == null)
					return RedirectToAction(nameof(Index));

				var posts = _db.Post.Where(p => p.PostContext.Contains(searchString) || p.PostTitle.Contains(searchString)).Include(p => p.PostImage).Include(p => p.CategoryPosts).ThenInclude(p => p.Category).ToList();

				if (posts is null)
					return RedirectToAction(nameof(Index));

				return View(posts);

			}
			[HttpGet]
			public IActionResult CategoryIndex(int Id)
			{
				if (Id == 0)
					return RedirectToAction(nameof(Index));

				var posts = _db.CategoryPost.Where(p => p.CategoryId == Id).Include(c => c.Post).ThenInclude(c => c.PostImage).Include(c => c.Category).ToList();

				if (posts is null)
					return RedirectToAction(nameof(Index));

				return View(posts);
			}
		}
	}