namespace CC.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateShopModels : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Shop_Products", name: "ShopCategory_ShopCategoryId", newName: "Category_ShopCategoryId");
            RenameColumn(table: "dbo.Shop_ProductReviews", name: "ShopProduct_ShopProductId", newName: "Product_ShopProductId");
            RenameIndex(table: "dbo.Shop_Products", name: "IX_ShopCategory_ShopCategoryId", newName: "IX_Category_ShopCategoryId");
            RenameIndex(table: "dbo.Shop_ProductReviews", name: "IX_ShopProduct_ShopProductId", newName: "IX_Product_ShopProductId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Shop_ProductReviews", name: "IX_Product_ShopProductId", newName: "IX_ShopProduct_ShopProductId");
            RenameIndex(table: "dbo.Shop_Products", name: "IX_Category_ShopCategoryId", newName: "IX_ShopCategory_ShopCategoryId");
            RenameColumn(table: "dbo.Shop_ProductReviews", name: "Product_ShopProductId", newName: "ShopProduct_ShopProductId");
            RenameColumn(table: "dbo.Shop_Products", name: "Category_ShopCategoryId", newName: "ShopCategory_ShopCategoryId");
        }
    }
}
