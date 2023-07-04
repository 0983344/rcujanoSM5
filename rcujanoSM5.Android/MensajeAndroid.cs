using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using rcujanoSM5.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency (typeof (MensajeAndroid))]

namespace rcujanoSM5.Droid
{
    public class MensajeAndroid : Mensaje
    {
        public void longAlert(string mensaje) 
        { 
            Toast.MakeText(Application.Context, mensaje , ToastLength.Long).Show();

        }
        public void shortAlert(string mensaje) 
        { 
            Toast.MakeText(Application.Context, mensaje , ToastLength.Short).Show();

        }
    }
}