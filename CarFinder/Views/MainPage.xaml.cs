using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarFinder
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void FindMyCarClicked(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new FindMyCarPage());
        }

        private async void FriendsCarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyFriendsEntryPage());
        }

        //  private async void WhoCanSeeClicked(object sender, EventArgs e)
        // {
        //
        //   var WhoCanSeePage = new (WhoCanSeeClickedPage);
        //     Navigation.PushAsync(WhoCanSeePage);
        // }


    }
}
