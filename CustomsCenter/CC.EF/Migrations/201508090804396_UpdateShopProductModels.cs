namespace CC.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateShopProductModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shop_Products", "UrlAlias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shop_Products", "UrlAlias");
        }
    }
}
