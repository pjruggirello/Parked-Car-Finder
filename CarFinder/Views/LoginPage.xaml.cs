using System;
using System.Collections.Generic;
using CarFinder.Data;
using System.Diagnostics;
using System.Linq;
using CarFinder.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarFinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        UserDatabaseController userDB = new UserDatabaseController();
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            userNameEntry.ReturnCommand = new Command(() => passwordEntry.Focus());
        }






        public async void SignInClicked(object sender, EventArgs e)
        {

            if (userNameEntry.Text != null && passwordEntry.Text != null)
            {
                var validData = userDB.LoginValidate(userNameEntry.Text, passwordEntry.Text);
                if (validData)
                {
                  
                    await Navigation.PushAsync(new FindMyCarPage());
                          Navigation.RemovePage(this);

                }
                else
                {
                   
                    await DisplayAlert("Login Failed", "Username or Password Incorrect", "OK");
                }

            }
         



          

        }
        private async void CreateAccountClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserRegistration());
        }
        
    }
}
