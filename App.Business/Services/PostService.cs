using App.Business.Services.Abstract;
using App.Persistence.Data;
using App.Persistence.Data.Entity;

namespace App.Business.Services
{
    public class PostService : IPostService
	{
		private readonly AppDbContext _db;

		public PostService(AppDbContext db)
		{
			_db = db;

		}
		public void DeleteById(int id)
		{
			var post = _db.Post.Find(id);
			if (post != null) _db.Post.Remove(post);
		}

		public IEnumerable<Post> GetAll()
		{
			return _db.Post.Select(e => e);
		}

		public Post GetById(int id)
		{
			return _db.Post.Find(id);
		}

		public string GetCategoryName(int id)
		{
			int categoryId = _db.CategoryPost.FirstOrDefault(p => p.PostId == id).CategoryId;
			return _db.Category.Find(categoryId).CategoryName;
		}

		public void Insert(Post entity)
		{
			_db.Post.Add(entity);
		}

		public void Update(Post entity)
		{
			if (_db.Post.Contains(entity)) _db.Post.Update(entity);
		}
		public void SaveChanges()
		{
			_db.SaveChanges();
		}
	}
}
