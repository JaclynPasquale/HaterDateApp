namespace HaterDateApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useridtostring : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dislikes", "ProfileId", "dbo.Profiles");
            DropIndex("dbo.Dislikes", new[] { "ProfileId" });
            AddColumn("dbo.Dislikes", "profile_Id", c => c.Int());
            AlterColumn("dbo.Dislikes", "ProfileId", c => c.String());
            AlterColumn("dbo.Dislikes", "QuestionValue", c => c.String());
            CreateIndex("dbo.Dislikes", "profile_Id");
            AddForeignKey("dbo.Dislikes", "profile_Id", "dbo.Profiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dislikes", "profile_Id", "dbo.Profiles");
            DropIndex("dbo.Dislikes", new[] { "profile_Id" });
            AlterColumn("dbo.Dislikes", "QuestionValue", c => c.Int(nullable: false));
            AlterColumn("dbo.Dislikes", "ProfileId", c => c.Int(nullable: false));
            DropColumn("dbo.Dislikes", "profile_Id");
            CreateIndex("dbo.Dislikes", "ProfileId");
            AddForeignKey("dbo.Dislikes", "ProfileId", "dbo.Profiles", "Id", cascadeDelete: true);
        }
    }
}
