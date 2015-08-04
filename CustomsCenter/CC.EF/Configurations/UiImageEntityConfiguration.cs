using System.Data.Entity.ModelConfiguration;
using CC.MODELS;

namespace CC.EF.Configurations
{

    class UiImageEntityConfiguration : EntityTypeConfiguration<UiImage>
    {
        public UiImageEntityConfiguration( )
        {
            ToTable("UIImages");
            HasKey(a => a.UiImageId);
        }
    }

}