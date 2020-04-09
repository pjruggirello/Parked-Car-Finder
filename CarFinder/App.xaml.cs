using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarFinder.Views;
using Xamarin.Forms;

namespace CarFinder
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            //MainPage = new LoginPage();
           MainPage = new NavigationPage(new LoginPage());
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
