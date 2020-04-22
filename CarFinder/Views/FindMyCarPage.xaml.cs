using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CarFinder
{

    public partial class FindMyCarPage : ContentPage
    {


        public FindMyCarPage()
        {
            // Starts the page
            InitializeComponent();
            // This is the function that creates the map
            FindMyLocation();
        }

        private async void FindMyCarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void SetMyLocationClicked(object sender, EventArgs e)
        {
            // This method adds a pin at the users location that says MyCar
            var location = await Geolocation.GetLastKnownLocationAsync();
            var theMap = FindByName("map") as Xamarin.Forms.Maps.Map;
            var mapCenter = new Position(location.Latitude, location.Longitude);
            var pin = new Pin { Type = PinType.Generic, Position = mapCenter, Label = "MyCar" };
            theMap.Pins.Add(pin);

        }

        private async void FindMyLocation()
        {
            try
            {
                // Finds and stores the users current location
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    // Takes the users stores location and sets it at the center of the map
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");

                    var theMap = FindByName("map") as Xamarin.Forms.Maps.Map;
                    var mapCenter = new Position(location.Latitude, location.Longitude);
                    theMap.MoveToRegion(MapSpan.FromCenterAndRadius(mapCenter, Distance.FromMiles(1)));

                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
    }
}
