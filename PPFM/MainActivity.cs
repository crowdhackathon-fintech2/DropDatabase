using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;
using System.Threading.Tasks;
using System;


namespace PPFM
{
    [Activity(Label = "PPFM", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button loginbutton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            loginbutton = FindViewById<Button>(Resource.Id.loginbutton);
            loginbutton.Click += enterscreen;
        }

        private void enterscreen(object sender, EventArgs e)
        {
            StartActivity(typeof(EnterScreen));
        }
    }
}

