using System;
using System.Collections.Generic;
using CarFinder.Models;
using Xamarin.Forms;

namespace CarFinder.Views
{
    public partial class UserRegistration : ContentPage
    {
        public UserRegistration()
        {
            InitializeComponent();
        }
        private void RegisterClicked(object sender, EventArgs e)
        {
            var Usernameview = FindByName("Entry_Username") as Entry;
            var Passwordview = FindByName("Entry_Password") as Entry;

            User user = new User(Usernameview.Text, Passwordview.Text);
            if (user.CheckInformation())
            {
                //await DisplayAlert("Login", "Logged In!", "Ok");
                Navigation.PushAsync(new LoginPage());
                Navigation.RemovePage(this);

                //TO ADD USER UPON COMPLETION OF IF STATEMENT USE THIS
                //App.UserDatabase.SaveUser(user);

                //TO REMOVE USER UPON COMPLETION OF STATEMENT IN IF STATEMENT US THIS
                //App.UserDatabase.DeleteUser(user);

            }
            else
            {
                DisplayAlert("Invalid Username or Password.", "The Username or password you entered did not meet the specified criteria.", "Please try again." );
            }

        }
    }

}
