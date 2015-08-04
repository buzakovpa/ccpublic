using System.Data.Entity.ModelConfiguration;
using CC.MODELS;

namespace CC.EF.Configurations
{

    class ShopProductEntityConfiguration : EntityTypeConfiguration<ShopProduct>
    {
        public ShopProductEntityConfiguration( )
        {
            ToTable("Shop_Products");
            HasKey(a => a.ShopProductId);
        }
    }

}