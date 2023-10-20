using App.Business.Dtos.Category;
using App.Business.Dtos.Page;
using App.Business.Dtos.Post;
using App.Business.Dtos.PostComment;
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
      CreateMap<CategoryDto, Category>().ReverseMap();
      CreateMap<ViewCategoryDto, Category>().ReverseMap();
      CreateMap<CreateOrEditCategoryDto, Category>().ReverseMap();
      //Post
      CreateMap<PostDto, Post>().ReverseMap();
      CreateMap<ViewPostDto, Post>().ReverseMap();
      CreateMap<CreateOrEditPostDto, Post>().ReverseMap();

      //Page
      CreateMap<PageDto, Page>().ReverseMap();
      CreateMap<ViewPageDto, Page>().ReverseMap();
      CreateMap<CreateOrEditPageDto, Page>().ReverseMap();

      //User
      CreateMap<UserDto, User>().ReverseMap();
      CreateMap<ViewUserDto, User>().ReverseMap();
      CreateMap<CreateOrEditUserDto, User>().ReverseMap();

      //Setting
      CreateMap<SettingDto, Setting>().ReverseMap();
      CreateMap<ViewSettingDto, Setting>().ReverseMap();
      CreateMap<CreateOrEditSettingDto, Setting>().ReverseMap();

      //postComment
      CreateMap<PostCommentCreateOrEditDto, PostComment>().ReverseMap();
    }
  }
}
