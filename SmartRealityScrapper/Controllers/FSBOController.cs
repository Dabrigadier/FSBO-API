using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SmartRealityScrapper.Models;
using SmartRealityScrapper.EF;


namespace SmartRealityScrapper.Controllers
{
    public class FSBOController : ApiController
    {
        DB_Driver dbdriver = new DB_Driver();
        // GET: api/FSBO
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FSBO/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FSBO
        //public string Post(string start_time, string end_time, List<int> listing_ids, string location, float min_price, float max_price)
        [HttpPost]
        public object Post( [FromBody] APIparams params_)
        {
            var api_type = params_.APIType;
            if(api_type==1)
            {
                var listing_ids = params_.listing_ids;
                var rows = dbdriver.Get_Ads_with_IDs(listing_ids);
                return rows;
            }
            if (api_type == 2)
            {
                var rows = dbdriver.Get_Listings_with_filter(params_.min_price, params_.max_price, params_.location,params_.address, params_.lat, params_.lng, params_.latlng_threshold, params_.offset,params_.limit, params_.sessionid, params_.userid);
                return rows;
            }
            else
            {
                return null;
            }

                //return Newtonsoft.Json.JsonConvert.SerializeObject(rows);
                
        }

        // PUT: api/FSBO/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FSBO/5
        public void Delete(int id)
        {
        }
    }
}
