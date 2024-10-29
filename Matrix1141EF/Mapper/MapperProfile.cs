using AutoMapper;
using Matrix1141EF.Data.Entity;
using Matrix1141EF.Model.DTO;

namespace Matrix1141EF.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserGetDTO>().ReverseMap();
            CreateMap<User,UserCreateDTO>().ReverseMap();
            CreateMap<Role,RoleCreateDTO>().ReverseMap();
            CreateMap<Category,CategoryCreateDTO>().ReverseMap();
            CreateMap<Category,GetCategoryDTO>().ReverseMap();
            CreateMap<Category,CategoryUpdateDTO>().ReverseMap();
            CreateMap<Category,CategoryDeleteDTO>().ReverseMap();
            CreateMap<Product, ProductCreateDTO>().ReverseMap();
            CreateMap<Product,GetProductDTO>().ReverseMap();
            CreateMap<Product,ProductUpdateDTO>().ReverseMap();
            CreateMap<Product,DeleteProductDTO>().ReverseMap(); 
        }
    }
}
