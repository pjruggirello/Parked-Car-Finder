using System;
using Xamarin.Forms;

namespace CarFinder
{
    public partial class MyFriendsEntryPage : ContentPage
    {
        public MyFriendsEntryPage()
        {
            InitializeComponent();
        }
        private async void FriendsCarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
