﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Landing
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPassengerPasswordPage : ContentPage
	{
		public ForgotPassengerPasswordPage ()
		{
			InitializeComponent ();
		}

        private void RetrievePasswordBtn_Clicked(object sender, EventArgs e)
        {

        }

        private async void CancelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}