
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace JsClock
{
    [Activity(Label = "SplashScreenActivity", MainLauncher =true, NoHistory = true)]
    public class SplashScreenActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.splashScreen);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        async void SimulateStartup ()
        {
            await Task.Delay(1500);
            StartActivity(new Intent(this, typeof(MainActivity)));
        }

        public override void OnBackPressed() 
        { 
            //override back button from being pressed to do nothing
        }

    }
}
