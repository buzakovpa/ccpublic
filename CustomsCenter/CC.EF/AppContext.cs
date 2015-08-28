using System.Data.Entity;
using System.Diagnostics;
using CC.EF.Configurations;
using CC.MODELS;

namespace CC.EF
{

    public class AppContext : DbContext
    {

        #region Shop

        public IDbSet<ShopCategory> ShopCategories { get; set; }
        public IDbSet<ShopProduct> ShopProducts { get; set; }
        public IDbSet<ShopProductReview> ShopProductReviews { get; set; }

        #endregion // Shop

        public IDbSet<UiElement> UiElements { get; set; }
        public IDbSet<UiImage> UiImages { get; set; }

        public AppContext()
            : base(@"Data Source=luueeyt55v.database.windows.net;Initial Catalog=CustomsCenterDatabase;Integrated Security=False;User ID=pbuzakov;Password=99v6yRgx;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False")
//            : base(@"Data Source=(localdb)\Projects;Initial Catalog=local_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UiElementEntityConfiguration());
            modelBuilder.Configurations.Add(new UiImageEntityConfiguration( ));

            modelBuilder.Configurations.Add(new ShopCategoryEntityConfiguration());
            modelBuilder.Configurations.Add(new ShopProductEntityConfiguration( ));
            modelBuilder.Configurations.Add(new ShopProductReviewEntityConfiguration( ));

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var result = base.SaveChanges();
            Debug.Print("SaveChanges: " + result);

            return result;
        }
    }
}