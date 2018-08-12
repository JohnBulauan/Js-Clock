
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace JsClock
{
    [Activity(Label = "AddAClockActivityLand", ConfigurationChanges = ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Landscape)]
    public class AddAClockActivityLand : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
           // SetContentView(Resource.Layout.land_addAClock);
        }
    }
}
