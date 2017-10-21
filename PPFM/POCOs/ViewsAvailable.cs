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
using Newtonsoft.Json;

namespace PPFM.POCOs
{
    public class ViewsAvailable
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("short_name")]
        public string short_name { get; set; }

        [JsonProperty("is_public")]
        public bool is_public { get; set; }
    }
}