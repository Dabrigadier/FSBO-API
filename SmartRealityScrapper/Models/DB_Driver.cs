using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartRealityScrapper.EF;
using System.Device;
using System.Device.Location;

namespace SmartRealityScrapper.Models
{
    public class DB_Driver
    {
        public static Model1 db = new Model1();

        public Model1 retunrDBObj()
        {
            return db;
        }
        public List<ListingDetail> Get_Ads_with_IDs(List<int> id)
        {

            return db.ListingDetails.Where(x => id.Contains(x.ListingID ?? -1)).ToList();
        }
        public List<Listing> Get_Listings_with_filter(string min_price_str, string max_price_str,string location,string address, double lat,double lng,double latlng_threshold,int offset,int limit,string sessionId,int userid)
        {
            var min_price = 0;
            var max_price = -1;
            if(location==null || location=="")
            {
                location = "";
            }
            if (address == null || address == "")
            {
                address = "";
            }

            location = location.ToLower();
            address = address.ToLower();
            var filtered_listing = new List<Listing>();
            if (min_price_str !="" && min_price_str != null)
            {
                min_price = int.Parse(min_price_str);
            }
            if (max_price_str != "" && max_price_str != null)
            {
                max_price = int.Parse(max_price_str);
                filtered_listing = db.Listings.Where(x => x.Price >= min_price && x.Price <= max_price && x.State.ToLower().Contains(location) && x.Address.ToLower().Contains(address)).ToList();
            }
            else
            {
                filtered_listing = db.Listings.Where(x => x.Price >= min_price && x.State.ToLower().Contains(location) && x.Address.ToLower().Contains(address)).ToList();
            }

            //SELECT* FROM(
            //SELECT *, (((acos(sin((@latitude * pi() / 180)) * sin((Latitude * pi() / 180)) + cos((@latitude * pi() / 180)) * cos((Latitude * pi() / 180)) * cos(((@longitude - Longitude) * pi() / 180)))) * 180 / pi()) * 60 * 1.1515 * 1.609344) as distance FROM Distances) t
            //WHERE distance <= @distance

            if (lng != 0.0 && lat != 0.0 && latlng_threshold != 0.0)
            {

                List<Listing> filtered_geocoding_listing = new List<Listing>();

                //foreach (var filtered_ad in enumerate(filtered_listing))
                foreach (var it in filtered_listing.Select((x, i) => new { Value = x, Index = i }) )
                {
                    if (it.Value.Lat != null && it.Value.Long != null)
                    {
                        var sCoord = new GeoCoordinate(it.Value.Lat ?? 0.0, it.Value.Long ?? 0.0);
                        var eCoord = new GeoCoordinate(lat, lng);
                        var dist = sCoord.GetDistanceTo(eCoord);

                        if (dist <= latlng_threshold)
                        {
                            filtered_geocoding_listing.Add(it.Value);
                            
                        }
                    }

                    

                }
                filtered_listing = filtered_geocoding_listing;
            }



            return filtered_listing.Skip(offset).Take(limit).ToList();

        }
    }
}