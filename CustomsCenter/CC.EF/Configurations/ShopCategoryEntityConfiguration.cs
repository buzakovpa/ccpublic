using System.Data.Entity.ModelConfiguration;
using CC.MODELS;

namespace CC.EF.Configurations
{

    class ShopCategoryEntityConfiguration : EntityTypeConfiguration<ShopCategory>
    {
        public ShopCategoryEntityConfiguration( )
        {
            ToTable("Shop_Categories");
            HasKey(a => a.ShopCategoryId);
        }
    }

}