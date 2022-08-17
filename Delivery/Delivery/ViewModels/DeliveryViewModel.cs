using Delivery.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Delivery.ViewModels
{
    public class DeliveryViewModel : BaseViewModel
    {
        public List<Categories> categories { get; set; }
        public List<PopularFood> popularFood { get; set; }

        #region Constructor
        public DeliveryViewModel(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPlatos();
        }
        #endregion
        public void MostrarPlatos()
        {
            categories = new List<Categories>
            {
                new Categories { Image="Burger", Title="Burger" },
                new Categories { Image="Seafood", Title="Seadfood" },
                new Categories { Image="SoftDrink", Title="Soft drink" }
            };
            popularFood = new List<PopularFood>
            {
                new PopularFood { Image="MenuOption", Title="Chicken Royal", Type="Hamburger", Price="$12"},
                new PopularFood { Image="MenuOption", Title="King Loobster", Type="Seafood", Price="$25" },
                new PopularFood { Image="MenuOption", Title="Chicken Royal", Type="Hamburger", Price="$12"},
            };
        }
    }
}
