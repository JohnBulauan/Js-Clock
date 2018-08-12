
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
using Java.Interop;

namespace JsClock
{
    [Activity(Label = "AddAClockActivity")]
    public class AddAClockActivity : Activity
    {
        private String a = "Europe/Amsterdam";
        private String ad = "Amsterdam";
        private String b = "America/Baltimore";
        private String ba = "Baltimore";
        private String c = "Africa/Cairo";
        private String ca = "Cairo";
        private String d = "Asia/Dalian";
        private String da = "Dalian";
        private String e = "America/Edmonton";
        private String ea = "Edmonton";
        private String f = "Europe/Florence";
        private String fe = "Florence";


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.addAClock);
            // Create your application here
        } 

        [Export("onClick")] 
        public void onClick(View view){
           
            if (view.Id == Resource.Id.btn1){
                StartActivity(new Intent(this, typeof(MainActivity)));
                Intent.PutExtra("row1", a);
                Intent.PutExtra("row1s", ad);
                SetResult(Result.Ok, Intent);
                Finish();
            }
            else if (view.Id == Resource.Id.btn2)
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
                Intent.PutExtra("row2", b);
                Intent.PutExtra("row2s", ba);
                SetResult(Result.Ok, Intent);
                Finish();
            }
            else if (view.Id == Resource.Id.btn3)
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
                Intent.PutExtra("row3", c);
                Intent.PutExtra("row3s", ca);
                SetResult(Result.Ok, Intent);
                Finish();
            }
            else if (view.Id == Resource.Id.btn4)
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
                Intent.PutExtra("row4", d);
                Intent.PutExtra("row4s", da);
                SetResult(Result.Ok, Intent);
                Finish();
            }
            else if (view.Id == Resource.Id.btn5)
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
                Intent.PutExtra("row5", e);
                Intent.PutExtra("row5s", ea);
                SetResult(Result.Ok, Intent);
                Finish();
            }
            else if (view.Id == Resource.Id.btn6)
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
                Intent.PutExtra("row6", f);
                Intent.PutExtra("row6s", fe);
                SetResult(Result.Ok, Intent);
                Finish();
            }

        }
    }
}
