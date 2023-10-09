using App.Persistence.Data.Entity;

namespace App.Business.Dtos.Post
{
  public class PostDto
  {
    public string PostTitle { get; set; }
    public string PostContext { get; set; }
    public PostImage PostImage { get; set; }
  }
}
