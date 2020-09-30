using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superstore.Models
{
    public class people
    {
        [BsonId]
        public ObjectId id { get; set; }

        [BsonElement("Person")]
        public String person { get; set; }

        [BsonElement("Region")]
        public String region { get; set; }
    }
}