using System;
using System.Threading.Tasks;
using mockProject.Persistences.Mongo.Models;
using MongoDB.Driver;

namespace mockProject.Persistences.Mongo
{
    public interface IMongoContext
    {
        IMongoCollection<User> GetUserCollection();

    }
}
