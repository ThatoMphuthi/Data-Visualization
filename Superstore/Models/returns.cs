using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superstore.Models
{
    public class returns
    {
        [BsonId]
        public ObjectId id { get; set; }

        [BsonElement("Returned")]
        public string returned { get; set; }

        [BsonElement("Order ID")]
        public String orderId { get; set; }

        [BsonElement("Region")]
        public String region { get; set; }
    }
}