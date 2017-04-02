using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Xml.Serialization;

namespace PTA_Restaurants.XForms.Models
{
    public class Restaurant
    {
        public int idRestaurant { get; set; }
        public object idDailyMenu { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string logo { get; set; }
        public object buffet { get; set; }
        public object price { get; set; }
        public object halfPrice { get; set; }
        public object date { get; set; }

        // Propiedad para leer la URL completa de la imagen de cada Restaurante
        private string logoURL = "http://nrestaurante-neuronable.rhcloud.com/images/logos/";
        public string LogoURL
        {
            get { return logoURL + logo; }
        }
    }

    public class RestaurantsCollection
    {
        public List<Restaurant> RestaurantsList { get; set; }
    }

}
