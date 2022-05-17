namespace StudentInfoSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationForTableScolarship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scolarships",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        student_name = c.String(nullable: false),
                        student_faculty_number = c.String(nullable: false),
                        scolarship_type = c.Int(nullable: false),
                        student_grades = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Scolarships");
        }
    }
}
