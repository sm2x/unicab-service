using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;

using UnicabApp.Services;
using UnicabApp.Droid;

[assembly: Dependency(typeof(ToastImpl))]
namespace UnicabApp.Droid
{
    public class ToastImpl : IToasts
    {
        public void LongToast(string message)
        {
            Toast.MakeText(MainActivity.Instance, message, ToastLength.Long).Show();
        }

        public void ShortToast(string message)
        {
            Toast.MakeText(MainActivity.Instance, message, ToastLength.Short).Show();
        }
    }
}