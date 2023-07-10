namespace BookRecommendation.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_table_element_created : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookOfTheDays", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookOfTheDays", "Created");
        }
    }
}
