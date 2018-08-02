using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using System;
using Java.Interop;

namespace JsClock
{
    [Activity(Label = "J's Clock", Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //ImageButton addClock = FindViewById<ImageButton>(Resource.Id.addTimeZone);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ImageButton addClock = FindViewById<ImageButton>(Resource.Id.addTimeZone);

            addClock.Click += delegate {
                StartActivity(new Intent(this, typeof(AddAClockActivity)));

            };

        }


    }
}

