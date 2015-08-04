namespace CC.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UIElements",
                c => new
                    {
                        UiElementId = c.Int(nullable: false, identity: true),
                        Alias = c.Int(nullable: false),
                        Value = c.String(),
                        Show = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UiElementId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UIElements");
        }
    }
}
