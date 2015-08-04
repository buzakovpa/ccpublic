namespace CC.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShopModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shop_Categories",
                c => new
                    {
                        ShopCategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Show = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ShopCategoryId);
            
            CreateTable(
                "dbo.Shop_Products",
                c => new
                    {
                        ShopProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Show = c.Boolean(nullable: false),
                        PurchasePrice = c.Double(nullable: false),
                        SellingPrice = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Image320X150_UiImageId = c.Int(),
                        Image840X300_UiImageId = c.Int(),
                        ShopCategory_ShopCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ShopProductId)
                .ForeignKey("dbo.UIImages", t => t.Image320X150_UiImageId)
                .ForeignKey("dbo.UIImages", t => t.Image840X300_UiImageId)
                .ForeignKey("dbo.Shop_Categories", t => t.ShopCategory_ShopCategoryId)
                .Index(t => t.Image320X150_UiImageId)
                .Index(t => t.Image840X300_UiImageId)
                .Index(t => t.ShopCategory_ShopCategoryId);
            
            CreateTable(
                "dbo.Shop_ProductReviews",
                c => new
                    {
                        ShopProductReviewId = c.Int(nullable: false, identity: true),
                        Show = c.Boolean(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Stars = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        ShopProduct_ShopProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ShopProductReviewId)
                .ForeignKey("dbo.Shop_Products", t => t.ShopProduct_ShopProductId)
                .Index(t => t.ShopProduct_ShopProductId);
            
            DropColumn("dbo.UIImages", "Alias");
            DropColumn("dbo.UIImages", "Show");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UIImages", "Show", c => c.Boolean(nullable: false));
            AddColumn("dbo.UIImages", "Alias", c => c.Int(nullable: false));
            DropForeignKey("dbo.Shop_Products", "ShopCategory_ShopCategoryId", "dbo.Shop_Categories");
            DropForeignKey("dbo.Shop_ProductReviews", "ShopProduct_ShopProductId", "dbo.Shop_Products");
            DropForeignKey("dbo.Shop_Products", "Image840X300_UiImageId", "dbo.UIImages");
            DropForeignKey("dbo.Shop_Products", "Image320X150_UiImageId", "dbo.UIImages");
            DropIndex("dbo.Shop_ProductReviews", new[] { "ShopProduct_ShopProductId" });
            DropIndex("dbo.Shop_Products", new[] { "ShopCategory_ShopCategoryId" });
            DropIndex("dbo.Shop_Products", new[] { "Image840X300_UiImageId" });
            DropIndex("dbo.Shop_Products", new[] { "Image320X150_UiImageId" });
            DropTable("dbo.Shop_ProductReviews");
            DropTable("dbo.Shop_Products");
            DropTable("dbo.Shop_Categories");
        }
    }
}
