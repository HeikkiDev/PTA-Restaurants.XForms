using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PTA_Restaurants.XForms.Models
{
    public class RestaurantDetailMenu
    {
        public int idProduct { get; set; }
        public int idProductType { get; set; }
        public object courseType { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public double? price1 { get; set; }
        public double? price2 { get; set; }
        public double? price3 { get; set; }
        public double? price4 { get; set; }
        public bool? vegetarian { get; set; }
        public object healthy { get; set; }
        public object celiac { get; set; }
        public bool hasNotAlergens { get; set; }
        public bool gluten { get; set; }
        public bool crustaceans { get; set; }
        public bool eggs { get; set; }
        public bool fish { get; set; }
        public bool peanuts { get; set; }
        public bool soy { get; set; }
        public bool milky { get; set; }
        public bool driedFruits { get; set; }
        public bool celery { get; set; }
        public bool mustard { get; set; }
        public bool sesame { get; set; }
        public bool sulfites { get; set; }
        public bool lupin { get; set; }
        public bool molluscs { get; set; }

        public bool IsVisiblePrice1 { get; set; }
        public bool IsVisiblePrice2 { get; set; }
        public bool IsVisiblePrice3 { get; set; }
        public bool IsVisiblePrice4 { get; set; }
    }

    public class RestaurantDetailMenuCollection
    {
        public List<RestaurantDetailMenu> RestaurantDetailMenuList { get; set; }
    }

}
