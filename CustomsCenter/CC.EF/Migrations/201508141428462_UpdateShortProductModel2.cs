namespace CC.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateShortProductModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shop_Products", "ShortDescription", c => c.String());
            AddColumn("dbo.Shop_Products", "FullDescription", c => c.String());
            DropColumn("dbo.Shop_Products", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shop_Products", "Description", c => c.String());
            DropColumn("dbo.Shop_Products", "FullDescription");
            DropColumn("dbo.Shop_Products", "ShortDescription");
        }
    }
}
