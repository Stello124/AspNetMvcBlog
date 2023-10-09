using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Persistence.Data.Entity
{
  public class Post
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "{0} boş geçilemez.")]
    [DisplayName("Gönderi Başlığı")]
    [StringLength(50, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
    [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
    public string PostTitle { get; set; }

    [Required(ErrorMessage = "{0} boş geçilemez.")]
    [DisplayName("Gönderi İçeriği")]
    [StringLength(1000, ErrorMessage = "{0} {1} karakterden fazla olamaz!")]
    [MinLength(10, ErrorMessage = "{0} en az {1} karakter olabilir!")]
    public string PostContext { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime PostDate { get; set; }

    public List<CategoryPost> CategoryPosts { get; set; }
    public PostImage PostImage { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }


  }
}
