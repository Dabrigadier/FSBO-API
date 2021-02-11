using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartRealityScrapper.Models
{
    public class APIparams
    {
        public int APIType { get; set; }
        public List<int> listing_ids { get; set; }
        public string location { get; set; }
        public string address { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public double latlng_threshold { get; set; }
        public string min_price { get; set; }
        public string max_price { get; set; }
        public int userid { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string sessionid { get; set; }
    }
}