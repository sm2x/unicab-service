using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicabApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Landing
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterNewUserPage : ContentPage
	{
		public RegisterNewUserPage ()
		{
			InitializeComponent ();

            var registrationTypeList = new List<string>();

            registrationTypeList.Add("Passenger");
            registrationTypeList.Add("Driver");

            registrationTypePicker.ItemsSource = registrationTypeList;
		}

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void MatricsCardCaptureBtn_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", "No camera detected.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                SaveToAlbum = true,
                Directory = "Unicab Service"
            });

            if (file == null)
                return;

            //await DisplayAlert("File Location", file.AlbumPath, "OK");
            MatricsCardCaptureBtn.Text = "Matrics Card Photo Added!";

        }
    }
}