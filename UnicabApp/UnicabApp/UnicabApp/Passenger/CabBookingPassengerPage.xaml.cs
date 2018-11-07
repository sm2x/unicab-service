using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace UnicabApp.Passenger
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CabBookingPassengerPage : ContentPage
	{
		public CabBookingPassengerPage ()
		{
			InitializeComponent ();

            SetMapToCurrentLocation();
		}

        private async void SetMapToCurrentLocation()
        {
            try
            {
                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(5.357513, 100.305717), Distance.FromKilometers(2)));

                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");

                    MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(location.Latitude, location.Longitude), Distance.FromKilometers(2)));
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
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