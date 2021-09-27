using MobileApp.XAML.Models;
using MobileApp.XAML.ViewModels;
using Newtonsoft.Json;
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
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

            //MainPage = new CoffeeEquipmentViewModel();
        }

        //public CoffeeEquipmentViewModel MainPage { get; }

        async void TapGestureRecognizer_Tapped(object sende, EventArgs e)
        {
            var coffe = ((MenuItem)sende).BindingContext as Coffee;
            await DisplayAlert("Coff Tap",coffe.Name, "Ok...");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
          
            //var JsonE = JsonConvert.SerializeObject(e);
            await DisplayAlert("sender", "Button clicked", "Ok...");
           // await DisplayAlert("e", JsonSender, "Ok...");
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var coffe = ((ListView)sender).SelectedItem as Coffee;
            if (coffe == null)
                return;

            await DisplayAlert("Coffee select", coffe.Name, "Ok");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var coffe = ((MenuItem)sender).BindingContext as Coffee;
            if (coffe == null)
                return;

            await DisplayAlert("Coffee Favorited", coffe.Name, "Ok");
        }
    }
}