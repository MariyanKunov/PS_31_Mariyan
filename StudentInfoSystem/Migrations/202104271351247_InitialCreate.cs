namespace StudentInfoSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        secName = c.String(),
                        surname = c.String(),
                        faculty = c.String(),
                        speciality = c.String(),
                        degree = c.String(),
                        facNumber = c.String(),
                        status = c.String(),
                        year = c.Int(nullable: false),
                        potok = c.Int(nullable: false),
                        group = c.Int(nullable: false),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Created = c.DateTime(nullable: false),
                        ActiveTill = c.DateTime(),
                        Password = c.String(),
                        FakNum = c.String(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Students");
        }
    }
}
