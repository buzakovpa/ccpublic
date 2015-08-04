using System.Data.Entity.ModelConfiguration;
using CC.MODELS;

namespace CC.EF.Configurations
{
    class UiElementEntityConfiguration : EntityTypeConfiguration<UiElement>
    {
        public UiElementEntityConfiguration( )
        {
            ToTable("UIElements");
            HasKey(a => a.UiElementId);
        }
    }

}
