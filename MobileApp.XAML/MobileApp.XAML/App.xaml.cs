using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.XAML
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new XamlExamplesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
