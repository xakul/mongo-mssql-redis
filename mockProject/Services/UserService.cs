using mockProject.Interfaces;
using mockProject.Persistences.Mongo;
using mockProject.Persistences.Mongo.Models;
using MongoDB.Driver;

namespace mockProject.Services
{
    public class UserService : IUserService
    {

        private readonly IMongoCollection<User> _userCollection;

        public UserService(IMongoContext mongoContext)
        {

           _userCollection = mongoContext.GetUserCollection();
                
        }

        public async Task<List<User>> GetAllUsers()
        {
           var userList = await _userCollection.Find(a => true).ToListAsync();

           return userList;
        }

        public async Task<User> CreateUser(User user)
        {
            _userCollection.InsertOne(user);

            return user;
        }
    }
}
