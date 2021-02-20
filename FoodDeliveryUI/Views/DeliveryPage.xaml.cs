using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FoodDeliveryUI.Views
{
    public partial class DeliveryPage : ContentPage
    {
        public DeliveryPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.DeliveryViewModel();
        }
    }
}
