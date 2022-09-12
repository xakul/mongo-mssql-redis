using AutoMapper;
using mockProject.Persistences.Mongo.Models;
using mockProject.ViewModels;

namespace mockProject.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User,UserViewModel>().ReverseMap();
        }
    }
}
 