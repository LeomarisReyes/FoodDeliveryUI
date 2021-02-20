using System;
using System.Collections.ObjectModel;
using FoodDeliveryUI.Models;

namespace FoodDeliveryUI.ViewModels
{
    public class DeliveryViewModel
    {
        public ObservableCollection<Categories> categories { get; set; }
        public ObservableCollection<PopularFood> popularFood { get; set; } 
        public DeliveryViewModel()
        {
            categories = new ObservableCollection<Categories>
            {
                new Categories { Image="Burger", Title="Burger" },
                new Categories { Image="Seafood", Title="Seadfood" },
                new Categories { Image="SoftDrink", Title="Soft drink" }
            };
            popularFood = new ObservableCollection<PopularFood>
            {
                new PopularFood { Image="MenuOption", Title="Chicken Royal", Type="Hamburger", Price="$12"},
                new PopularFood { Image="MenuOption", Title="King Loobster", Type="Seafood", Price="$25" },
                new PopularFood { Image="MenuOption", Title="Chicken Royal", Type="Hamburger", Price="$12"},
            };
        }
    }
}
