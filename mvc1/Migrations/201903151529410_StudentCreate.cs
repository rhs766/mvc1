namespace mvc1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Period = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
