using AppParcialdos.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppParcialdos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CountryPage();
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
