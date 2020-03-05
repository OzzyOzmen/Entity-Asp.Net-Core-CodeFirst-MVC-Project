using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class OzzyEntityDataBaseContext : DbContext
    {
        public OzzyEntityDataBaseContext()
        {
        }

        public OzzyEntityDataBaseContext(DbContextOptions<OzzyEntityDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<AllCommentsbyPost> AllCommentsbyPost { get; set; }
        public virtual DbSet<AllCommentsbyUser> AllCommentsbyUser { get; set; }
        public virtual DbSet<AllCustomers> AllCustomers { get; set; }
        public virtual DbSet<AllEmployees> AllEmployees { get; set; }
        public virtual DbSet<AllGalleries> AllGalleries { get; set; }
        public virtual DbSet<AllOrderDetails> AllOrderDetails { get; set; }
        public virtual DbSet<AllOrders> AllOrders { get; set; }
        public virtual DbSet<AllPosts> AllPosts { get; set; }
        public virtual DbSet<AllProducts> AllProducts { get; set; }
        public virtual DbSet<AllReferences> AllReferences { get; set; }
        public virtual DbSet<AllUsers> AllUsers { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Galleries> Galleries { get; set; }
        public virtual DbSet<GalleryCategories> GalleryCategories { get; set; }
        public virtual DbSet<GeneralSettings> GeneralSettings { get; set; }
        public virtual DbSet<Newsletters> Newsletters { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PostCategories> PostCategories { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ReferenceCategories> ReferenceCategories { get; set; }
        public virtual DbSet<Referencess> Referencess { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Territories> Territories { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=mssqladdress;Database=db_name;User=db_username;Password=db_password;"); // change here
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "db_name"); // change here

            modelBuilder.Entity<AboutUs>(entity =>
            {
                entity.Property(e => e.AboutUsId).HasColumnName("AboutUsID");

                entity.Property(e => e.AboutUsDescription).HasMaxLength(500);

                entity.Property(e => e.AboutUsTitle).HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(50);
            });

            modelBuilder.Entity<AllCommentsbyPost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllCommentsbyPost");

                entity.Property(e => e.CommentDiscription).HasMaxLength(50);

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentTitle).HasMaxLength(50);

                entity.Property(e => e.PostTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<AllCommentsbyUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllCommentsbyUser");

                entity.Property(e => e.CommentDiscription).HasMaxLength(50);

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<AllCustomers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllCustomers");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactTitle).HasMaxLength(50);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.TerritoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<AllEmployees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllEmployees");

                entity.Property(e => e.Birthday).HasMaxLength(50);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.HireDate).HasMaxLength(50);

                entity.Property(e => e.IdentityNumber).HasMaxLength(50);

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.TerritoryName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserPhoto).HasMaxLength(50);
            });

            modelBuilder.Entity<AllGalleries>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllGalleries");

                entity.Property(e => e.GalleryCategoryName).HasMaxLength(50);

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");

                entity.Property(e => e.GalleryName).HasMaxLength(50);

                entity.Property(e => e.GalleryPhoto).HasMaxLength(50);
            });

            modelBuilder.Entity<AllOrderDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllOrderDetails");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<AllOrders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllOrders");

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.RequiredDate).HasMaxLength(50);

                entity.Property(e => e.ShippingAddress).HasMaxLength(50);

                entity.Property(e => e.ShippingCost).HasMaxLength(50);

                entity.Property(e => e.ShippingDate).HasMaxLength(50);

                entity.Property(e => e.ShippingName).HasMaxLength(50);

                entity.Property(e => e.ShippingPostalCode).HasMaxLength(50);

                entity.Property(e => e.TerritoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<AllPosts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllPosts");

                entity.Property(e => e.PostCategoryName).HasMaxLength(50);

                entity.Property(e => e.PostDiscription).HasMaxLength(50);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.PostPhoto).HasMaxLength(50);

                entity.Property(e => e.PostTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<AllProducts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllProducts");

                entity.Property(e => e.ProductCategoryName).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductPhoto).HasMaxLength(50);

                entity.Property(e => e.ShowCasePhoto).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<AllReferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllReferences");

                entity.Property(e => e.ReferenceCategoryName).HasMaxLength(50);

                entity.Property(e => e.ReferenceDescription).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.ReferenceLogo).HasMaxLength(50);

                entity.Property(e => e.ReferenceName).HasMaxLength(50);
            });

            modelBuilder.Entity<AllUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllUsers");

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IdentityNumber).HasMaxLength(50);

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.TerritoryName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(50);

                entity.Property(e => e.UserPhoto).HasMaxLength(50);

                entity.Property(e => e.UserRole).HasMaxLength(50);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK__Comments__C3B4DFAAA457A10E");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentDiscription).HasMaxLength(50);

                entity.Property(e => e.CommentTitle).HasMaxLength(50);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactMessage).HasMaxLength(50);

                entity.Property(e => e.Sender).HasMaxLength(50);

                entity.Property(e => e.SendingDate).HasMaxLength(50);
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__Countrie__10D160BF3873D6C9");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64B8C0D627A7");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactTitle).HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF18B25F2B5");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Birthday).HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HireDate).HasMaxLength(50);

                entity.Property(e => e.IdentityNumber).HasMaxLength(50);

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserPhoto).HasMaxLength(50);
            });

            modelBuilder.Entity<Galleries>(entity =>
            {
                entity.HasKey(e => e.GalleryId)
                    .HasName("PK__Gallerie__CF4F7B957CCF4BE2");

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");

                entity.Property(e => e.GalleryCategoryId).HasColumnName("GalleryCategoryID");

                entity.Property(e => e.GalleryName).HasMaxLength(50);

                entity.Property(e => e.GalleryPhoto).HasMaxLength(50);
            });

            modelBuilder.Entity<GalleryCategories>(entity =>
            {
                entity.HasKey(e => e.GalleryCategoryId)
                    .HasName("PK__GalleryC__3C191B2462C586D7");

                entity.Property(e => e.GalleryCategoryId).HasColumnName("GalleryCategoryID");

                entity.Property(e => e.GalleryCategoryName).HasMaxLength(50);

                entity.Property(e => e.GalleryCategoryPhoto).HasMaxLength(50);
            });

            modelBuilder.Entity<GeneralSettings>(entity =>
            {
                entity.Property(e => e.GeneralSettingsId).HasColumnName("GeneralSettingsID");

                entity.Property(e => e.CompanyAddress).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailPassword).HasMaxLength(50);

                entity.Property(e => e.Keywords).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SiteLogo).HasMaxLength(50);

                entity.Property(e => e.SmtpAddress).HasMaxLength(50);

                entity.Property(e => e.SmtpPort).HasMaxLength(50);

                entity.Property(e => e.WebSiteAddress).HasMaxLength(50);

                entity.Property(e => e.WebSiteName).HasMaxLength(50);
            });

            modelBuilder.Entity<Newsletters>(entity =>
            {
                entity.HasKey(e => e.NewsletterId)
                    .HasName("PK__Newslett__34A1DE1D47DB923A");

                entity.Property(e => e.NewsletterId).HasColumnName("NewsletterID");

                entity.Property(e => e.Email).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderDet__C3905BAF530EEE07");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BAFFC80F09E");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.OrderDate).HasMaxLength(50);

                entity.Property(e => e.RequiredDate).HasMaxLength(50);

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.ShippingAddress).HasMaxLength(50);

                entity.Property(e => e.ShippingCost).HasMaxLength(50);

                entity.Property(e => e.ShippingCountryId).HasColumnName("ShippingCountryID");

                entity.Property(e => e.ShippingDate).HasMaxLength(50);

                entity.Property(e => e.ShippingName).HasMaxLength(50);

                entity.Property(e => e.ShippingPostalCode).HasMaxLength(50);

                entity.Property(e => e.ShippingRegionId).HasColumnName("ShippingRegionID");

                entity.Property(e => e.ShippingTerritoryId).HasColumnName("ShippingTerritoryID");
            });

            modelBuilder.Entity<Pages>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("PK__Pages__C565B124ED5C7CE4");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.PageDescription).HasMaxLength(50);

                entity.Property(e => e.PageUrl).HasMaxLength(50);

                entity.Property(e => e.Pagetitle).HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(50);
            });

            modelBuilder.Entity<PostCategories>(entity =>
            {
                entity.HasKey(e => e.PostCategoryId)
                    .HasName("PK__PostCate__FE61E369A56231F3");

                entity.Property(e => e.PostCategoryId).HasColumnName("PostCategoryID");

                entity.Property(e => e.PostCategoryName).HasMaxLength(50);

                entity.Property(e => e.PostCategoryPhoto).HasMaxLength(50);
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__Posts__AA126038833A1A53");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.PostCategoryId).HasColumnName("PostCategoryID");

                entity.Property(e => e.PostDiscription).HasMaxLength(50);

                entity.Property(e => e.PostPhoto).HasMaxLength(50);

                entity.Property(e => e.PostTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductCategories>(entity =>
            {
                entity.HasKey(e => e.ProductCategoryId)
                    .HasName("PK__ProductC__3224ECEEDF3B2CC5");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductCategoryName).HasMaxLength(50);

                entity.Property(e => e.ProductCategoryPhoto).HasMaxLength(50);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6EDD6DB50F7");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductPhoto).HasMaxLength(50);

                entity.Property(e => e.ShowCasePhoto).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ReferenceCategories>(entity =>
            {
                entity.HasKey(e => e.ReferenceCategoryId)
                    .HasName("PK__Referenc__457C5813845EAD0E");

                entity.Property(e => e.ReferenceCategoryId).HasColumnName("ReferenceCategoryID");

                entity.Property(e => e.ReferenceCategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Referencess>(entity =>
            {
                entity.HasKey(e => e.ReferenceId)
                    .HasName("PK__Referenc__E1A99A792BA16705");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.ReferenceCategoryId).HasColumnName("ReferenceCategoryID");

                entity.Property(e => e.ReferenceDescription).HasMaxLength(50);

                entity.Property(e => e.ReferenceLogo).HasMaxLength(50);

                entity.Property(e => e.ReferenceName).HasMaxLength(50);
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PK__Regions__ACD844434492DCC4");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.RegionName).HasMaxLength(50);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Photo).HasMaxLength(50);

                entity.Property(e => e.ServiceDescription).HasMaxLength(50);

                entity.Property(e => e.ServiceTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<Shippers>(entity =>
            {
                entity.HasKey(e => e.ShipperId)
                    .HasName("PK__Shippers__1F8AFFB941A2F9F3");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK__Supplier__4BE666941EA00827");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierName).HasMaxLength(50);
            });

            modelBuilder.Entity<Territories>(entity =>
            {
                entity.HasKey(e => e.TerritoryId)
                    .HasName("PK__Territor__2BECD2E487777F53");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PK__UserRole__3D978A550EFACAD8");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.UserRole).HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CCAC4E9FF5D2");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IdentityNumber).HasMaxLength(50);

                entity.Property(e => e.NameSurname).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(50);

                entity.Property(e => e.UserPhoto).HasMaxLength(50);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
