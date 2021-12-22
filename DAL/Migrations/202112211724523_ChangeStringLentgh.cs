namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStringLentgh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "Description", c => c.String(nullable: false, maxLength: 400));
            AlterColumn("dbo.Answers", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Questions", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Tests", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tests", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Questions", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Answers", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Tests", "Description");
        }
    }
}
