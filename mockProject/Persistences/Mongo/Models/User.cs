﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mockProject.Persistences.Mongo.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

    }
}
