using PTA_Restaurants.XForms.Models;
using PTA_Restaurants.XForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PTA_Restaurants.XForms.ViewModels
{
    class RestaurantDetailMenuViewModel : INotifyPropertyChanged
    {
        private RestaurantsServiceAPI RestaurantsService { get; } = new RestaurantsServiceAPI();

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        private bool isVisible = false;
        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; OnPropertyChanged(); }
        }

        private Restaurant restaurant;
        public Restaurant Restaurant
        {
            get { return restaurant; }
            set
            {
                restaurant = value;
                OnPropertyChanged();
            }
        }

        private RestaurantDetail restaurantDetail;
        public RestaurantDetail RestaurantDetail
        {
            get { return restaurantDetail; }
            set
            {
                restaurantDetail = value;
                OnPropertyChanged();
            }
        }

        private RestaurantDetailMenuCollection restaurantDetailMenuCollection;
        public RestaurantDetailMenuCollection RestaurantDetailMenuCollection
        {
            get { return restaurantDetailMenuCollection; }
            set
            {
                restaurantDetailMenuCollection = value;
                OnPropertyChanged();
            }
        }

        // Constructor
        public RestaurantDetailMenuViewModel(Restaurant restaurant, RestaurantDetail restaurantDetail)
        {
            Restaurant = restaurant;
            RestaurantDetail = restaurantDetail;
            ExecuteGetRestaurantDetailMenuCommand(restaurantDetail);
        }

        private Command getRestaurantDetailMenu;

        public Command GetRestaurantDetailMenuCommand
        {
            get
            {
                return getRestaurantDetailMenu ?? (getRestaurantDetailMenu = new Command<RestaurantDetail>(ExecuteGetRestaurantDetailMenuCommand));
            }
        }

        private async void ExecuteGetRestaurantDetailMenuCommand(RestaurantDetail restaurantDetail)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            GetRestaurantDetailMenuCommand.ChangeCanExecute();
            try
            {
                RestaurantDetailMenuCollection = await RestaurantsService.GetRestaurantDetailMenu(restaurantDetail);
                if (RestaurantDetailMenuCollection == null || RestaurantDetailMenuCollection.RestaurantDetailMenuList == null || RestaurantDetailMenuCollection.RestaurantDetailMenuList.Count == 0)
                    IsVisible = true;
                else
                    IsVisible = false;
            }
            catch
            {
                IsVisible = true;
                RestaurantDetailMenuCollection = null;
            }
            finally
            {
                IsBusy = false;
                GetRestaurantDetailMenuCommand.ChangeCanExecute();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
