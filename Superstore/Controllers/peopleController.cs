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
    public class peopleController : Controller
    {
        private MongoDBContext dBContext;
        private IMongoCollection<people> peopleCollections;
        // GET: people

        public peopleController()
        {
            dBContext = new MongoDBContext();
            peopleCollections = dBContext.database.GetCollection<people>("GlobalSuperstorePeople2016");

        }
        public ActionResult IndexPeople()
        {
            List<people> myPeople = peopleCollections.AsQueryable<people>().ToList();
            return View(myPeople);
        }
    }
}