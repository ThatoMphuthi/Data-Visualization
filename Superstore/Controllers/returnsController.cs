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
    public class returnsController : Controller
    {
        private MongoDBContext dBContext;
        private IMongoCollection<returns> returnCollections;
        // GET: return

        public returnsController()
        {
            dBContext = new MongoDBContext();
            returnCollections = dBContext.database.GetCollection<returns>("GlobalSuperstoreReturn2016(1)");

        }
        public ActionResult IndexReturns(int? i)
        {
            List<returns> myReturns = returnCollections.AsQueryable<returns>().ToList();
            return View(myReturns);
        }
    }
}