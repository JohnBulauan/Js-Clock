using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using System;
using Java.Interop;
using Java.Util;

namespace JsClock
{
    [Activity(Label = "J's Clock", Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            String row1 = Intent.GetStringExtra("row1");
            String row1s = Intent.GetStringExtra("row1s");
            String row2 = Intent.GetStringExtra("row2");
            String row2s = Intent.GetStringExtra("row2s");
            String row3 = Intent.GetStringExtra("row3");
            String row3s = Intent.GetStringExtra("row3s");
            String row4 = Intent.GetStringExtra("row4");
            String row4s = Intent.GetStringExtra("row4s");
            String row5 = Intent.GetStringExtra("row5");
            String row5s = Intent.GetStringExtra("row5s");
            String row6 = Intent.GetStringExtra("row6");
            String row6s = Intent.GetStringExtra("row6s");

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ImageButton addClock = FindViewById<ImageButton>(Resource.Id.addTimeZone);
            addClock.Click += delegate {
                StartActivity(new Intent(this, typeof(AddAClockActivity)));
            };

            TextClock txtc1 = (TextClock)FindViewById(Resource.Id.row1);
            TextView txtv1 = (TextView)FindViewById(Resource.Id.row1s);
            TextClock txtc2 = (TextClock)FindViewById(Resource.Id.row2);
            TextView txtv2 = (TextView)FindViewById(Resource.Id.row2s);
            TextClock txtc3 = (TextClock)FindViewById(Resource.Id.row3);
            TextView txtv3 = (TextView)FindViewById(Resource.Id.row3s);
            TextClock txtc4 = (TextClock)FindViewById(Resource.Id.row4);
            TextView txtv4 = (TextView)FindViewById(Resource.Id.row4s);
            TextClock txtc5 = (TextClock)FindViewById(Resource.Id.row5);
            TextView txtv5 = (TextView)FindViewById(Resource.Id.row5s);
            TextClock txtc6 = (TextClock)FindViewById(Resource.Id.row6);
            TextView txtv6 = (TextView)FindViewById(Resource.Id.row6s);

        }
    }
}

