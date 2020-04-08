using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarFinder
{
    public partial class FindMyCarPage : ContentPage
    {
        StackLayout stack;
        public FindMyCarPage()
        {
            InitializeComponent();
        }
        private async void FindMyCarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
