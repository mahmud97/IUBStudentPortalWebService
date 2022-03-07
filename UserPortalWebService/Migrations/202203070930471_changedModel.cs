namespace UserPortalWebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "WorkPlace", c => c.String(nullable: false, maxLength: 512));
            AddColumn("dbo.Users", "JobRole", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "JobRole");
            DropColumn("dbo.Users", "WorkPlace");
        }
    }
}
