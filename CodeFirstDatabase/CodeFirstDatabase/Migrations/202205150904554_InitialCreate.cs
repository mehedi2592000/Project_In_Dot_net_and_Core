namespace CodeFirstDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        emId = c.Int(nullable: false, identity: true),
                        empname = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.emId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
