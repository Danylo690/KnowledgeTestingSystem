namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIncorrectName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Questions", name: "TaskId", newName: "TestId");
            RenameIndex(table: "dbo.Questions", name: "IX_TaskId", newName: "IX_TestId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Questions", name: "IX_TestId", newName: "IX_TaskId");
            RenameColumn(table: "dbo.Questions", name: "TestId", newName: "TaskId");
        }
    }
}
