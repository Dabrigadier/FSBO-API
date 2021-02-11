namespace SmartRealityScrapper.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Listing
    {
        public int id { get; set; }

        public string Title { get; set; }

        public string HTML { get; set; }

        public int? ListingID { get; set; }

        public int? Price { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string Features { get; set; }

        public string AreaDetails { get; set; }

        public string Url { get; set; }

        public string ImageUrl { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public DateTime? LastUpdated { get; set; }

        public DateTime? PostingTime { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }

        public double? Lat { get; set; }

        public double? Long { get; set; }
    }
}
