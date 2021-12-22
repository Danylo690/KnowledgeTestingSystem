namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Questions", "Test_Id", "dbo.Tests");
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            DropIndex("dbo.Questions", new[] { "Test_Id" });
            RenameColumn(table: "dbo.Answers", name: "Question_Id", newName: "QuestionId");
            RenameColumn(table: "dbo.Questions", name: "Test_Id", newName: "TaskId");
            AlterColumn("dbo.Answers", "QuestionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Questions", "TaskId", c => c.Int(nullable: false));
            CreateIndex("dbo.Answers", "QuestionId");
            CreateIndex("dbo.Questions", "TaskId");
            AddForeignKey("dbo.Answers", "QuestionId", "dbo.Questions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Questions", "TaskId", "dbo.Tests", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "TaskId", "dbo.Tests");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.Questions", new[] { "TaskId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            AlterColumn("dbo.Questions", "TaskId", c => c.Int());
            AlterColumn("dbo.Answers", "QuestionId", c => c.Int());
            RenameColumn(table: "dbo.Questions", name: "TaskId", newName: "Test_Id");
            RenameColumn(table: "dbo.Answers", name: "QuestionId", newName: "Question_Id");
            CreateIndex("dbo.Questions", "Test_Id");
            CreateIndex("dbo.Answers", "Question_Id");
            AddForeignKey("dbo.Questions", "Test_Id", "dbo.Tests", "Id");
            AddForeignKey("dbo.Answers", "Question_Id", "dbo.Questions", "Id");
        }
    }
}
