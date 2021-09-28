using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp.XAML
{
    public partial class PropertyValuesPage : ContentPage
    {
        void ButtonClicked(object sender, System.EventArgs e)
        {
            ((Button)sender).Text = "It is so!";
        }

        public PropertyValuesPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Italic Alert", ((Button)sender).Text, "Ok");
            ((Button)sender).TextColor = Color.Red;
        }
    }
}
