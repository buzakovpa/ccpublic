namespace CC.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUiImageModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UIImages",
                c => new
                    {
                        UiImageId = c.Int(nullable: false, identity: true),
                        Alias = c.Int(nullable: false),
                        Folder = c.String(),
                        Filename = c.String(),
                        Show = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UiImageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UIImages");
        }
    }
}
