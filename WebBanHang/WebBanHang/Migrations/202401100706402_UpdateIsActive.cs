namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "IsAvtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.New", "IsAvtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Post", "IsAvtive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Product", "IsAvtive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "IsAvtive");
            DropColumn("dbo.Post", "IsAvtive");
            DropColumn("dbo.New", "IsAvtive");
            DropColumn("dbo.Category", "IsAvtive");
        }
    }
}
