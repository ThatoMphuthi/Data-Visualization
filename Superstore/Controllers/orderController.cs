using MongoDB.Driver;
using Superstore.App_Start;
using Superstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superstore.Controllers
{
    public class orderController : Controller
    {
        private MongoDBContext dBContext;
        private IMongoCollection<orders> ordersCollections;
        // GET: order

        public orderController()
        {
            dBContext = new MongoDBContext();
            ordersCollections = dBContext.database.GetCollection<orders>("GlobalSuperstoreOrders2016");

        }
        public ActionResult IndexOrders()
        {
            List<orders> Orders = ordersCollections.AsQueryable<orders>().ToList();
            return View(Orders);
        }
    }
}