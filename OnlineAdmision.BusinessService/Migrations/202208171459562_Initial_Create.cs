namespace OnlineAdmision.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        LandMark = c.String(),
                        AreaName = c.String(),
                        City = c.String(),
                        District = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        PINCode = c.String(),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedOn = c.DateTime(nullable: false),
                        DeletedBy = c.String(),
                        DeletedOn = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        Candidate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id)
                .Index(t => t.Candidate_Id);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfAdmission = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedOn = c.DateTime(nullable: false),
                        DeletedBy = c.String(),
                        DeletedOn = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Fees = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Duration = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        UpdatedOn = c.DateTime(nullable: false),
                        DeletedBy = c.String(),
                        DeletedOn = c.DateTime(nullable: false),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseCandidates",
                c => new
                    {
                        Course_Id = c.Int(nullable: false),
                        Candidate_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_Id, t.Candidate_Id })
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .ForeignKey("dbo.Candidates", t => t.Candidate_Id, cascadeDelete: true)
                .Index(t => t.Course_Id)
                .Index(t => t.Candidate_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseCandidates", "Candidate_Id", "dbo.Candidates");
            DropForeignKey("dbo.CourseCandidates", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Addresses", "Candidate_Id", "dbo.Candidates");
            DropIndex("dbo.CourseCandidates", new[] { "Candidate_Id" });
            DropIndex("dbo.CourseCandidates", new[] { "Course_Id" });
            DropIndex("dbo.Addresses", new[] { "Candidate_Id" });
            DropTable("dbo.CourseCandidates");
            DropTable("dbo.Courses");
            DropTable("dbo.Candidates");
            DropTable("dbo.Addresses");
        }
    }
}
