namespace CC.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateShopModels2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shop_Categories", "UrlAlias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shop_Categories", "UrlAlias");
        }
    }
}
