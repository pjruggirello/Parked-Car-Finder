using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarFinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void SignInClicked(object sender, EventArgs e)
        {
            User user = new User("Entry_Username", "Entry_Password");
            if (user.CheckInformation())
            {
                //await DisplayAlert("Login", "Logged In!", "Ok");
                Navigation.PushAsync(new MainPage());
                Navigation.RemovePage(this);
               
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct, empty username or password.", "Ok");
            }
        }
        
    }
}
