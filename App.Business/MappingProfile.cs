using App.Business.Dtos.Category;
using App.Business.Dtos.Page;
using App.Business.Dtos.Post;
using App.Business.Dtos.Setting;
using App.Business.Dtos.User;
using App.Persistence.Data.Entity;
using AutoMapper;

namespace App.Business
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      //Category
      CreateMap<CategoryDto, Category>();
      CreateMap<ViewCategoryDto, Category>();
      CreateMap<CreateOrEditCategoryDto, Category>();

      CreateMap<Category, CategoryDto>();
      CreateMap<Category, ViewCategoryDto>();
      CreateMap<Category, CreateOrEditCategoryDto>();
      //Post
      CreateMap<PostDto, Post>();
      CreateMap<ViewPostDto, Post>();
      CreateMap<CreateOrEditPostDto, Post>();

      CreateMap<Post, PostDto>();
      CreateMap<Post, ViewPostDto>();
      CreateMap<Post, CreateOrEditPostDto>();

      //Page
      CreateMap<PageDto, Page>();
      CreateMap<ViewPageDto, Page>();
      CreateMap<CreateOrEditPageDto, Page>();

      CreateMap<Page, PageDto>();
      CreateMap<Page, ViewPageDto>();
      CreateMap<Page, CreateOrEditPageDto>();

      //User
      CreateMap<UserDto, User>();
      CreateMap<ViewUserDto, User>();
      CreateMap<CreateOrEditUserDto, User>();

      CreateMap<User, UserDto>();
      CreateMap<User, ViewUserDto>();
      CreateMap<User, CreateOrEditUserDto>();

      //Setting
      CreateMap<SettingDto, Setting>();
      CreateMap<ViewSettingDto, Setting>();
      CreateMap<CreateOrEditSettingDto, Setting>();

      CreateMap<Setting, SettingDto>();
      CreateMap<Setting, ViewSettingDto>();
      CreateMap<Setting, CreateOrEditSettingDto>();
    }
  }
}
