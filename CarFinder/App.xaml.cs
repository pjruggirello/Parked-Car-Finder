using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarFinder.Data;
using CarFinder.Views;
using Xamarin.Forms;

namespace CarFinder
{
    public partial class App : Application
    {
    
        static UserDatabaseController userDatabase;

        public App()
        {

            InitializeComponent();

           
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

        public static UserDatabaseController UserDatabase
        {
            get
            {
                if(userDatabase ==null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }


    }
}
