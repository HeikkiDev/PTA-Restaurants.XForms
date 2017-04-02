using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PTA_Restaurants.XForms.Models
{
    public class FirstCours
    {
        public int idProduct { get; set; }
        public int idProductType { get; set; }
        public object courseType { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public object price1 { get; set; }
        public object price2 { get; set; }
        public object price3 { get; set; }
        public object price4 { get; set; }
        public bool vegetarian { get; set; }
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
    }

    public class SecondCours
    {
        public int idProduct { get; set; }
        public int idProductType { get; set; }
        public object courseType { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public object price1 { get; set; }
        public object price2 { get; set; }
        public object price3 { get; set; }
        public object price4 { get; set; }
        public bool vegetarian { get; set; }
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
    }

    public class Garnish
    {
        public int idProduct { get; set; }
        public int idProductType { get; set; }
        public object courseType { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public object price1 { get; set; }
        public object price2 { get; set; }
        public object price3 { get; set; }
        public object price4 { get; set; }
        public bool vegetarian { get; set; }
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
    }

    public class Dessert
    {
        public int idProduct { get; set; }
        public int idProductType { get; set; }
        public object courseType { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public object price1 { get; set; }
        public object price2 { get; set; }
        public object price3 { get; set; }
        public object price4 { get; set; }
        public bool vegetarian { get; set; }
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
    }

    public class Drink
    {
        public int idProduct { get; set; }
        public int idProductType { get; set; }
        public object courseType { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double? price1 { get; set; }
        public double? price2 { get; set; }
        public object price3 { get; set; }
        public object price4 { get; set; }
        public bool vegetarian { get; set; }
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
    }

    public class OfferList
    {
        public object idOffer { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class DailyMenuList
    {
        public int idDailyMenu { get; set; }
        public string date { get; set; }
        public bool buffet { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public double halfPrice { get; set; }
        public List<FirstCours> firstCourses { get; set; }
        public List<SecondCours> secondCourses { get; set; }
        public List<Garnish> garnishes { get; set; }
        public List<Dessert> desserts { get; set; }
        public List<Drink> drinks { get; set; }
    }

    public class RestaurantDetail
    {
        public int idMenuCategory { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string price1 { get; set; }
        public string price2 { get; set; }
        public string price3 { get; set; }
        public string price4 { get; set; }
    }

    public class RestaurantDetailCollection
    {
        public List<DailyMenuList> DailyMenuList { get; set; }
        public List<RestaurantDetail> RestaurantDetailList { get; set; }
        public List<RestaurantDetail> categoryList { get; set; }
        public List<OfferList> OfferList { get; set; }
        public object eventList { get; set; }
    }

}
