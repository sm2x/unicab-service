﻿using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using UnicabApp.Models;
using UnicabApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Landing
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterNewPassengerPage : ContentPage
	{
		public RegisterNewPassengerPage ()
		{
			InitializeComponent ();

		}

        private async void SubmitButton_Clicked(object sender, EventArgs e)
        {
            //IPStatus testStatus = GeneralService.TestServerStatus(string.Format(Common.AppServerConstants.PassengerApplicantsUrl, string.Empty));
            //if (testStatus != IPStatus.Success)
            //{
            //    await DisplayAlert("Passenger Sign Up", "App server unreachable, please try again later. (ping status: " + testStatus.ToString() + ")", "OK");
            //    await Navigation.PopModalAsync();
            //    return;
            //}

            SubmitButton.Text = "Submitting ...";
            SubmitButton.IsEnabled = false;

            PassengerApplicant applicant = new PassengerApplicant()
            {
                EmailAddress = emailEntry.Text,
                MatricsNo = matricsnoEntry.Text,
                FirstName = firstNameEntry.Text,
                LastName = lastNameEntry.Text,
                Password = newPasswordAgainEntry.Text
            };

            HttpStatusCode statusCode = await App.CredentialsManager.TryPassengerSignUp(applicant);

            if (statusCode == HttpStatusCode.Created)
            {
                await DisplayAlert("Passenger Sign Up", "Sign up successful. Kindly wait for admin approval.", "OK");
            }
            else
            {
                await DisplayAlert("Passenger Sign Up", "Sign up failed. Please try again. (status code: " + statusCode.ToString() + ")", "OK");
            }

            await Navigation.PopModalAsync();

        }

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        //private async void MatricsCardCaptureBtn_Clicked(object sender, EventArgs e)
        //{
        //    await CrossMedia.Current.Initialize();

        //    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
        //    {
        //        await DisplayAlert("No Camera", "No camera detected.", "OK");
        //        return;
        //    }

        //    var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
        //    {
        //        SaveToAlbum = true,
        //        Directory = "Unicab Service"
        //    });

        //    if (file == null)
        //        return;

        //    //await DisplayAlert("File Location", file.AlbumPath, "OK");
        //    MatricsCardCaptureBtn.Text = "Matrics Card Photo Added!";

        //}
    }
}