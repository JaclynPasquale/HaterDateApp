namespace HaterDateApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedchartostring : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Gender", c => c.String(nullable: false));
            AddColumn("dbo.Profiles", "PreferredGender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "PreferredGender");
            DropColumn("dbo.Profiles", "Gender");
        }
    }
}
