using AutoMapper;
using mockProject.Persistences.Mssql;
using mockProject.ViewModels;

namespace mockProject.AutoMapper
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderViewModel>().ReverseMap();
        }
    }
}
