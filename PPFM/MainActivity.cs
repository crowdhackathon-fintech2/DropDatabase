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
            string test = string.Empty;
            // Get our button from the layout resource ,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            //9d7f2ef4 - 7262 - 4429 - a487 - 7979e4a76447User1user1 @nbg.grNBGNBG.gr

            // ...

            var client = new RestClient("http://rxnav.nlm.nih.gov/REST/RxTerms/rxcui/");

            var request = new RestRequest(String.Format("{0}/allinfo", "198440"));
            client.ExecuteAsync(request, response => {
                Console.WriteLine(response.Content+"testtestestestest");
            });

        }


    }
}

