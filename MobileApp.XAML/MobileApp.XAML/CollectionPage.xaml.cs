using MobileApp.XAML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionPage : ContentPage
    {
        public CollectionPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Coll Button", "Button clicked", "Ok...");
           
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var coffe = e.CurrentSelection.FirstOrDefault() as Coffee;
            if (coffe == null)
                return;

            await DisplayAlert("Collections View", coffe.Name, "Ok");
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}