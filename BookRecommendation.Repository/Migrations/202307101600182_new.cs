namespace BookRecommendation.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookOfTheDays", "Author_Id", "dbo.Authors");
            DropIndex("dbo.BookOfTheDays", new[] { "Author_Id" });
            RenameColumn(table: "dbo.BookOfTheDays", name: "Author_Id", newName: "AuthorId");
            AlterColumn("dbo.BookOfTheDays", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.BookOfTheDays", "AuthorId");
            AddForeignKey("dbo.BookOfTheDays", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookOfTheDays", "AuthorId", "dbo.Authors");
            DropIndex("dbo.BookOfTheDays", new[] { "AuthorId" });
            AlterColumn("dbo.BookOfTheDays", "AuthorId", c => c.Int());
            RenameColumn(table: "dbo.BookOfTheDays", name: "AuthorId", newName: "Author_Id");
            CreateIndex("dbo.BookOfTheDays", "Author_Id");
            AddForeignKey("dbo.BookOfTheDays", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
