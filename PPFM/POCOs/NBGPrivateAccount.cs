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
    public class NBGPrivateAccount
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("label")]
        public string label { get; set; }

        [JsonProperty("bank_id")]
        public string bank_id { get; set; }

        [JsonProperty("views_available")]
        public IList<ViewsAvailable> views_available { get; set; }
    }

}