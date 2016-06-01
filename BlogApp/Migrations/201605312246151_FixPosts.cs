namespace BlogApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixPosts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posts", "Content", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Content", c => c.Int(nullable: false));
            DropColumn("dbo.Posts", "CreationDate");
        }
    }
}
