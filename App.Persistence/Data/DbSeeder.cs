using App.Persistence.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Data
{
  public class DbSeeder
  {
    public static void Seed(ModelBuilder modelBuilder)
    {
      //Category
      modelBuilder.Entity<Category>().HasData(
          new Category
          {
            Id = 1,
            CategoryName = "Technology"
          },
          new Category
          {
            Id = 2,
            CategoryName = "Nature"
          }
          );
      //User
      modelBuilder.Entity<User>().HasData(
          new User
          {
            Id = 1,
            UserName = "Kibariye",
            UserSurname = "Tokmak",
            UserEmail = "KibisTokmak@gmail.com",
            UserPassword = "341582"
          },
          new User
          {
            Id = 2,
            UserName = "Zeki",
            UserSurname = "Müren",
            UserEmail = "Zekis@hotmail.com",
            UserPassword = "319482"
          }
          );
      //Post
      modelBuilder.Entity<Post>().HasData(
          new Post
          {
            Id = 1,
            PostTitle = "Lorem ipsum dolor sit amet.",
            PostContext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce elementum, enim et dapibus efficitur, augue augue blandit ex, et scelerisque orci felis quis massa. Donec viverra risus augue, ac auctor nisl ultrices id. Aliquam luctus mauris vitae laoreet ullamcorper. Mauris suscipit nisl sapien, sed auctor arcu feugiat vel. Integer rhoncus, diam sed consectetur dignissim, elit nibh eleifend eros, et eleifend risus augue id ante. Aenean eu risus scelerisque, mollis nulla at, finibus felis. Nulla blandit ipsum eget leo eleifend lobortis. Nulla in fringilla sem. Phasellus accumsan vitae tortor non tincidunt. Sed convallis, augue sit amet aliquet tempor, eros eros fringilla libero, ultrices placerat urna augue eu nisl. Praesent suscipit viverra nulla, sed condimentum ante iaculis eget. Nam auctor faucibus metus, non gravida leo pellentesque et.",
            UserId = 1,
            PostDate = new DateTime(2023, 12, 13)
          },
           new Post
           {
             Id = 2,
             PostTitle = "Consectetur adipiscing.",
             PostContext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vulputate id nisi tristique ullamcorper. Vestibulum aliquam ipsum ac diam lacinia, vitae posuere urna efficitur. Cras tempus quam ut condimentum iaculis. Donec euismod enim et tristique feugiat. Suspendisse non malesuada eros. Nulla id enim sit amet orci fringilla interdum. Etiam ultricies pharetra elit, eget vulputate odio. Fusce facilisis in lacus id lacinia. In ex lacus, convallis nec sapien non, placerat consectetur ipsum. Quisque cursus ligula id ullamcorper sagittis. Vivamus ultricies mollis augue. Nunc vel erat vitae purus vestibulum egestas.",
             UserId = 2,
             PostDate = new DateTime(2020, 7, 15)

           }
          );
      //CategoryPost
      modelBuilder.Entity<CategoryPost>().HasData(
        new CategoryPost
        {
          PostId = 1,
          CategoryId = 2
        },
          new CategoryPost
          {
            PostId = 2,
            CategoryId = 1
          }
        );

      //Page
      modelBuilder.Entity<Page>().HasData(
        new Page
        {
          Id = 1,
          PageTitle = "About",
          PageContext = "Sed convallis, augue sit amet aliquet tempor, eros eros fringilla libero, ultrices placerat urna augue eu nisl. Praesent suscipit viverra nulla, sed condimentum ante iaculis eget. Nam auctor faucibus metus, non gravida leo pellentesque et."

        },
         new Page
         {
           Id = 2,
           PageTitle = "Contact",
           PageContext = " Etiam ultricies pharetra elit, eget vulputate odio. Fusce facilisis in lacus id lacinia. In ex lacus, convallis nec sapien non, placerat consectetur ipsum. Quisque cursus ligula id ullamcorper sagittis. Vivamus ultricies mollis augue. Nunc vel erat vitae purus vestibulum egestas."

         }
        );
      //Post Image
      modelBuilder.Entity<PostImage>().HasData(
          new PostImage
          {
            Id = 1,
            PostId = 1,
            ImageUrl = "../images/slider/slider1.jpg",

          },
          new PostImage
          {
            Id = 2,
            PostId = 2,
            ImageUrl = "../images/slider/slider2.jpg",
          }
          );

    }
  }
}
