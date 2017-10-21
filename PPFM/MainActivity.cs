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

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

        }


    }
}

