using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTA_Restaurants.XForms.Models;
using System.Net.Http;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace PTA_Restaurants.XForms.Services
{
    class RestaurantsServiceAPI
    {
        private string RestaurantsListURLBase = "http://nrestaurante-neuronable.rhcloud.com/ws/api/restaurant/public/v1/summary/1/{0}/{1}/{2}"; // año/mes/día
        private string ImagesURLBase = "http://nrestaurante-neuronable.rhcloud.com/images/logos/{0}"; // nombre de la imagen: propiedad 'logo'
        private string RestaurantDetailURLBase = "http://nrestaurante-neuronable.rhcloud.com/ws/api/restaurant/public/v1/menu/{0}/{1}/{2}/{3}"; // id de restaurante/año/mes/día
        private string RestaurantDetailMenuURLBase = "http://nrestaurante-neuronable.rhcloud.com/ws/api/product/public/v1/category/{0}"; // Id de categoría

        /// <summary>
        /// 
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
        public async Task<RestaurantsCollection> GetRestaurants(DateTime today)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(RestaurantsListURLBase, today.Year, today.Month, today.Day);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                RestaurantsCollection restaurantsList = new RestaurantsCollection();

                try
                {
                    List<Restaurant> rList  = JsonConvert.DeserializeObject<List<Restaurant>>(json);
                    restaurantsList.RestaurantsList = rList;
                }
                catch
                {
                    throw;
                }

                return restaurantsList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="restaurant"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        public async Task<RestaurantDetailCollection> GetRestaurantDetail(Restaurant restaurant, DateTime today)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(RestaurantDetailURLBase, restaurant.idRestaurant, today.Year, today.Month, today.Day);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                RestaurantDetailCollection restaurantDetailList = null;

                try
                {
                    restaurantDetailList =  JsonConvert.DeserializeObject<RestaurantDetailCollection>(json);
                }
                catch
                {
                    throw;
                }

                return restaurantDetailList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="restaurantDetail"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        public async Task<RestaurantDetailMenuCollection> GetRestaurantDetailMenu(RestaurantDetail restaurantDetail)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(RestaurantDetailMenuURLBase, restaurantDetail.idMenuCategory);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                RestaurantDetailMenuCollection restaurantDetailList = new RestaurantDetailMenuCollection();

                try
                {
                    restaurantDetailList.RestaurantDetailMenuList = JsonConvert.DeserializeObject<List<RestaurantDetailMenu>>(json);
                }
                catch
                {
                    throw;
                }

                return restaurantDetailList;
            }
        }
    }
}
