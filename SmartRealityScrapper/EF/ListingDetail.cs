namespace SmartRealityScrapper.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ListingDetail
    {
        public int id { get; set; }

        public int? ListingID { get; set; }

        public string Image_urls { get; set; }

        public string Title { get; set; }

        public int? Price { get; set; }

        public string Address { get; set; }

        public double? Lat { get; set; }

        public double? Long { get; set; }

        public string County { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Features { get; set; }

        public double? Bedrooms { get; set; }

        public double? Bathrooms { get; set; }

        public string Type { get; set; }

        public string Garage { get; set; }

        public double? Area { get; set; }

        public string Description { get; set; }

        public string Amenities { get; set; }

        public string Owner_Name { get; set; }

        public string Owner_Details { get; set; }

        public string Phone_no { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
