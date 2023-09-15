using AspNetMvcBlog.Data.Entity;

namespace AspNetMvcBlog.Models
{
    public class NavbarViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Page> Pages { get; set; }
    }
}