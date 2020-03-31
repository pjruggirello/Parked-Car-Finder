using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarFinder
{
    public partial class FindMyCarPage : ContentPage
    {
        public FindMyCarPage()
        {
            InitializeComponent();
        }
        private async void FindMyCarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
