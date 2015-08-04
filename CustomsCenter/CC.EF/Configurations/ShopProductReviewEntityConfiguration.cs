using System.Data.Entity.ModelConfiguration;
using CC.MODELS;

namespace CC.EF.Configurations
{

    class ShopProductReviewEntityConfiguration : EntityTypeConfiguration<ShopProductReview>
    {
        public ShopProductReviewEntityConfiguration( )
        {
            ToTable("Shop_ProductReviews");
            HasKey(a => a.ShopProductReviewId);
        }
    }

}