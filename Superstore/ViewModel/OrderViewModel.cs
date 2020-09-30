using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superstore.ViewModel
{
    public class OrderViewModel
    {
        public int Africa_count { get; set; }
        public int Australia_count { get; set; }
        public int Germany_count { get; set; }
        public int Senegal_count { get; set; }
        public int Brazil_count { get; set; }
        public int China_count { get; set; }

        //bar graph
        public int Phones_count { get; set; }
        public int Tables_count { get; set; }
        public int Chairs_count { get; set; }
        public int Copiers_count { get; set; }
        public int Art_count { get; set; }
        public int Storage_count { get; set; }
        public int Appliances_count { get; set; }
        public int Machines_count { get; set; }
        public int Furnishings_count { get; set; }
        public int Binders_count { get; set; }
        public int Bookcases_count { get; set; }
        public int Paper_count { get; set; }

        //statistic people
        public int Caribbean_People { get; set; }
        public int Ocenia_People { get; set; }
        public int SouthAmerica_People { get; set; }
        public int SouthernAfrica_People { get; set; }

        //sales stats

        public int USCA_Order { get; set; }
        public int AsiaPacific_Order { get; set; }
        public int Europe_Order { get; set; }
        public int Africa_Order { get; set; }
        public int LATAM_Order { get; set; }
    }
}