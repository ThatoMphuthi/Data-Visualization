using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superstore.Models
{
    public class Registration
    {
        [BsonId]
        public ObjectId id { get; set; }

        [BsonElement("username")]
        public string username { get; set; }

        [BsonElement("email")]
        public String email { get; set; }

        [BsonElement("password")]
        public String password { get; set; }

        public string errorMessage { get; set; }

    }
}