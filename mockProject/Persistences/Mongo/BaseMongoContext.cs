using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using mockProject.Persistences.Utils;
using mockProject.Persistences.Mongo.Models;

namespace mockProject.Persistences.Mongo
{
    public class BaseMongoContext : IMongoContext
    {

        private readonly IConfiguration Configuration;

        private readonly IMongoCollection<User> _userCollection;

        public BaseMongoContext()
        {
            Configuration = AppSettingsConfig.Configuration;

            var client = new MongoClient(Configuration["MongoDBSettings:Connection"]);
            
            var database = client.GetDatabase(Configuration["MongoDBSettings:DatabaseName"]);

            _userCollection = database.GetCollection<User>(Configuration["MongoDBSettings:UserCollection"]);
        }

        public IMongoCollection<User> GetUserCollection() => _userCollection;

    }
}
