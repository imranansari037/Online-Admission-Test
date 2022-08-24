namespace OnlineAdmision.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_nullable_date_time : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Addresses", "DeletedOn", c => c.DateTime());
            AlterColumn("dbo.Candidates", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Candidates", "DeletedOn", c => c.DateTime());
            AlterColumn("dbo.Courses", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Courses", "DeletedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "DeletedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Candidates", "DeletedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Candidates", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Addresses", "DeletedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Addresses", "UpdatedOn", c => c.DateTime(nullable: false));
        }
    }
}
