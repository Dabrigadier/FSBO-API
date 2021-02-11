namespace SmartRealityScrapper.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ListingDetail> ListingDetails { get; set; }
        public virtual DbSet<Listing> Listings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Image_urls)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Features)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Garage)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Amenities)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Owner_Name)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Owner_Details)
                .IsUnicode(false);

            modelBuilder.Entity<ListingDetail>()
                .Property(e => e.Phone_no)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.HTML)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.Features)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.AreaDetails)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Listing>()
                .Property(e => e.Zipcode)
                .IsUnicode(false);
        }
    }
}
