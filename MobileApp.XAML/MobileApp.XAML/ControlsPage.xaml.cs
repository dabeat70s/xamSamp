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
    public partial class ControlsPage : ContentPage
    {
       
        public ControlsPage()
        {
            InitializeComponent();
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {

            ((Button)sender).Text = "It is so!";
        }

        async protected void ImageTapped(object sender, EventArgs e)
        {

            Image image = ((Image)sender);
            await image.FadeTo(0.1, 2000, Easing.BounceOut);
            image.Opacity = .8;
            await Task.Delay(1000);
            image.Opacity = .7;
            await Task.Delay(1000);
            image.Opacity = .6;
            await Task.Delay(1000);
            image.Opacity = .5;
            await Task.Delay(1000);
            image.Opacity = .3;
            await Task.Delay(4000);
            image.Opacity = 1;
        }

        private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var serchText = ((SearchBar)sender).Text;
            await DisplayAlert("Searching", serchText, "Ok");
            
        }
    }
}