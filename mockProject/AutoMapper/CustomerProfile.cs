using AutoMapper;
using mockProject.Persistences.Mssql;
using mockProject.ViewModels;

namespace mockProject.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
        }
    }
}
