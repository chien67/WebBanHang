namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Post", "Posts_Id", "dbo.Post");
            DropIndex("dbo.Post", new[] { "Posts_Id" });
            AlterColumn("dbo.Category", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Category", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.Category", "SeoDescription", c => c.String(maxLength: 250));
            DropColumn("dbo.Post", "Posts_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "Posts_Id", c => c.Int());
            AlterColumn("dbo.Category", "SeoDescription", c => c.String());
            AlterColumn("dbo.Category", "SeoTitle", c => c.String());
            AlterColumn("dbo.Category", "Title", c => c.String());
            CreateIndex("dbo.Post", "Posts_Id");
            AddForeignKey("dbo.Post", "Posts_Id", "dbo.Post", "Id");
        }
    }
}
