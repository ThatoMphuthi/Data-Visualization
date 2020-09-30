using MongoDB.Driver;
using Superstore.App_Start;
using Superstore.Models;
using Superstore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superstore.Controllers
{
    public class dashboardController : Controller
    {
        private MongoDBContext context;

        private IMongoCollection<orders> orderCollection;
        private IMongoCollection<people> peopleCollection;
        private IMongoCollection<returns> returnCollection;

        OrderViewModel viewOrder = new OrderViewModel();

        public dashboardController()
        {
            context = new MongoDBContext();
            orderCollection = context.database.GetCollection<orders>("GlobalSuperstoreOrders2016");
            peopleCollection = context.database.GetCollection<people>("GlobalSuperstorePeople2016");
            returnCollection = context.database.GetCollection<returns>("GlobalSuperstoreReturns2016(1)");
        }

        // GET: dashboard
        public ActionResult Index()
        {
            List<orders> Orders = orderCollection.AsQueryable<orders>().ToList();
            List<people> People = peopleCollection.AsQueryable<people>().ToList();
            List<returns> Returns = returnCollection.AsQueryable<returns>().ToList();




            int totalAfrica = (from x in Orders.Where(x => x.Country.Contains("Africa")) select x.State).Count();
            int totalAustralia = (from x in Orders.Where(x => x.Country.Contains("Australia")) select x.State).Count();
            int totalGermany = (from x in Orders.Where(x => x.Country.Contains("Germany")) select x.State).Count();
            int totalSenegal = (from x in Orders.Where(x => x.Country.Contains("Senegal")) select x.State).Count();
            int totalBrazil = (from x in Orders.Where(x => x.Country.Contains("Brazil")) select x.State).Count();
            int totalChina = (from x in Orders.Where(x => x.Country.Contains("China")) select x.State).Count();


            //bar graph Orders

            int totalPhone = (from x in Orders.Where(x => x.SubCategory.Contains("Phones")) select x.Quantity).Count();
            int totalTables = (from x in Orders.Where(x => x.SubCategory.Contains("Tables")) select x.Quantity).Count();
            int totalChairs = (from x in Orders.Where(x => x.SubCategory.Contains("Chairs")) select x.Quantity).Count();
            int totalCopiers = (from x in Orders.Where(x => x.SubCategory.Contains("Copiers")) select x.Quantity).Count();
            int totalArt = (from x in Orders.Where(x => x.SubCategory.Contains("Art")) select x.Quantity).Count();
            int totalStorage = (from x in Orders.Where(x => x.SubCategory.Contains("Storage")) select x.Quantity).Count();
            int totalAppliances = (from x in Orders.Where(x => x.SubCategory.Contains("Appliances")) select x.Quantity).Count();
            int totalMachines = (from x in Orders.Where(x => x.SubCategory.Contains("Machines")) select x.Quantity).Count();
            int totalFurnishings = (from x in Orders.Where(x => x.SubCategory.Contains("Furnishing")) select x.Quantity).Count();
            int totalBinders = (from x in Orders.Where(x => x.SubCategory.Contains("Machines")) select x.Quantity).Count();
            int totalBookcases = (from x in Orders.Where(x => x.SubCategory.Contains("Bookcases")) select x.Quantity).Count();
            int totalPaper = (from x in Orders.Where(x => x.SubCategory.Contains("Paper")) select x.Quantity).Count();

            //statistics people
            int totalCaribbean_People = (from x in People.Where(x => x.region.Contains("Caribbean")) select x.person).Count();
            int totalOcenia_People = (from x in People.Where(x => x.region.Contains("Oceania")) select x.person).Count();
            int totalSouthAmerica_People = (from x in People.Where(x => x.region.Contains("South America")) select x.person).Count();
            int totalSouthernAfrica_People = (from x in People.Where(x => x.region.Contains("Southern Africa")) select x.person).Count();

            int totalUSCA = (from x in Orders.Where(x => x.State.Contains("USCA")) select x.Quantity).Count();
            int totalAsiaPacific = (from x in Orders.Where(x => x.State.Contains("Asia Pacific")) select x.Quantity).Count();
            int totalEurope = (from x in Orders.Where(x => x.State.Contains("Europe")) select x.Quantity).Count();
            int totalAfricaC = (from x in Orders.Where(x => x.State.Contains("Africa")) select x.Quantity).Count();
            int totalLATAM = (from x in Orders.Where(x => x.State.Contains("LATAM")) select x.Quantity).Count();



            //statistics graph
            viewOrder.Caribbean_People = totalCaribbean_People;
            viewOrder.Ocenia_People = totalOcenia_People;
            viewOrder.SouthAmerica_People = totalSouthAmerica_People;
            viewOrder.SouthernAfrica_People = totalSouthernAfrica_People;

            //SALES STATS
            viewOrder.USCA_Order = totalUSCA;
            viewOrder.AsiaPacific_Order = totalAsiaPacific;
            viewOrder.SouthAmerica_People = totalEurope;
            viewOrder.Africa_Order = totalAfricaC;
            viewOrder.LATAM_Order = totalLATAM;


            viewOrder.Africa_count = totalAfrica;
            viewOrder.Australia_count = totalAustralia;
            viewOrder.Germany_count = totalGermany;
            viewOrder.Senegal_count = totalSenegal;
            viewOrder.Brazil_count = totalBrazil;
            viewOrder.China_count = totalChina;

            //bar graph
            viewOrder.Phones_count = totalPhone;
            viewOrder.Tables_count = totalTables;
            viewOrder.Chairs_count = totalChairs;
            viewOrder.Copiers_count = totalCopiers;
            viewOrder.Art_count = totalArt;
            viewOrder.Storage_count = totalStorage;
            viewOrder.Appliances_count = totalAppliances;
            viewOrder.Machines_count = totalMachines;
            viewOrder.Furnishings_count = totalFurnishings;
            viewOrder.Binders_count = totalBinders;
            viewOrder.Bookcases_count = totalBookcases;
            viewOrder.Paper_count = totalPaper;


            return View(viewOrder);
        }
    }
}