using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superstore.Models
{
    public class orders
    {

        [BsonId]
        public ObjectId id { get; set; }

        [BsonElement("Row ID")]
        public string RowID { get; set; }

        [BsonElement("Order ID")]
        public String OrderID { get; set; }

        [BsonElement("Order Date")]
        public String OrderDate { get; set; }

        [BsonElement("Ship Date")]
        public String ShipDate { get; set; }

        [BsonElement("Ship Mode")]
        public String ShipMode { get; set; }

        [BsonElement("Customer ID")]
        public String CustomerID { get; set; }

        [BsonElement("Segment")]
        public String Segment { get; set; }

        [BsonElement("Postal Code")]
        public String PostalCode { get; set; }

        [BsonElement("City")]
        public String City { get; set; }

        [BsonElement("State")]
        public String State { get; set; }

        [BsonElement("Country")]
        public String Country { get; set; }

        [BsonElement("Region")]
        public String Region { get; set; }

        [BsonElement("Market")]
        public String Market { get; set; }

        [BsonElement("Product ID")]
        public String ProductID { get; set; }

        [BsonElement("Category")]
        public String Category { get; set; }

        [BsonElement("Sub-Category")]
        public String SubCategory { get; set; }

        [BsonElement("Product Name")]
        public String ProductName { get; set; }

        [BsonElement("Sales")]
        public String Sales { get; set; }

        [BsonElement("Quantity")]
        public int Quantity { get; set; }

        [BsonElement("Discount")]
        public String Discount { get; set; }

        [BsonElement("Profit")]
        public String Profit { get; set; }

        [BsonElement("Shipping Cost")]
        public String ShippingCost { get; set; }

        [BsonElement("Order Priority")]
        public String OrderPriority { get; set; }
    }
}