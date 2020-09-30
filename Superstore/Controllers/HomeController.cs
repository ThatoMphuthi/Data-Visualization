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
    public class HomeController : Controller
    {
        private MongoDBContext dBContext;
        private IMongoCollection<Registration> userCollections;

        public HomeController()
        {
            dBContext = new MongoDBContext();
            userCollections = dBContext.database.GetCollection<Registration>("GlobalSuperstoreRegistration");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Registration user)
        {
            userCollections.InsertOne(user);
            return RedirectToAction("Login", "Home");
        }


        [HttpPost]
        public ActionResult Login(Registration users)
        {
            List<Registration> user = userCollections.AsQueryable<Registration>().ToList();

            var userdetails = user.Where(x => x.email == users.email && x.password == users.password).FirstOrDefault();

            if (userdetails == null)
            {
                users.errorMessage = "Invalid Credentials";
                return View("Login", users);
            }
            else
            {
                return RedirectToAction("Index", "dashboard");
            }

        }
    }
}
    