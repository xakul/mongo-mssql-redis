using mockProject.Persistences.Mongo.Models;

namespace mockProject.Interfaces
{
    public interface IUserService
    {
       Task<List<User>> GetAllUsers();

       Task<User> CreateUser(User user);
    }
}
