using AutoMapper;
using mockProject.Persistences.Mssql;
using mockProject.ViewModels;

namespace mockProject.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
