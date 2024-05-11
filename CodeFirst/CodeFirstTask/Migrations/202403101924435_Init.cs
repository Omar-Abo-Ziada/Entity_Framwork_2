namespace CodeFirstTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.String(maxLength: 50),
                        DepartmentID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Department", t => t.DepartmentID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.TeacherTransfer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeaherID = c.Int(),
                        FromSchoolID = c.Int(),
                        ToSchoolID = c.Int(),
                        Date = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.teacher", t => t.TeaherID)
                .ForeignKey("dbo.School", t => t.ToSchoolID)
                .ForeignKey("dbo.School", t => t.FromSchoolID)
                .Index(t => t.TeaherID)
                .Index(t => t.FromSchoolID)
                .Index(t => t.ToSchoolID);
            
            CreateTable(
                "dbo.teacher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SchoolID = c.Int(),
                        Name = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(storeType: "date"),
                        NationalID = c.String(maxLength: 50),
                        Code = c.String(maxLength: 10),
                        Job = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 15),
                        Qualifications = c.String(maxLength: 100),
                        QualificationDate = c.DateTime(storeType: "date"),
                        HiringDate = c.DateTime(storeType: "date"),
                        Adress_Country = c.String(),
                        Adress_City = c.String(),
                        Adress_Street = c.String(),
                        Notes = c.String(maxLength: 200),
                        TeacherTtansferID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.SchoolID)
                .Index(t => t.SchoolID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherTransfer", "FromSchoolID", "dbo.School");
            DropForeignKey("dbo.School", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.TeacherTransfer", "ToSchoolID", "dbo.School");
            DropForeignKey("dbo.TeacherTransfer", "TeaherID", "dbo.teacher");
            DropForeignKey("dbo.teacher", "SchoolID", "dbo.School");
            DropIndex("dbo.teacher", new[] { "SchoolID" });
            DropIndex("dbo.TeacherTransfer", new[] { "ToSchoolID" });
            DropIndex("dbo.TeacherTransfer", new[] { "FromSchoolID" });
            DropIndex("dbo.TeacherTransfer", new[] { "TeaherID" });
            DropIndex("dbo.School", new[] { "DepartmentID" });
            DropTable("dbo.teacher");
            DropTable("dbo.TeacherTransfer");
            DropTable("dbo.School");
            DropTable("dbo.Department");
        }
    }
}
