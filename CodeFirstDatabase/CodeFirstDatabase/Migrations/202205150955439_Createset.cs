namespace CodeFirstDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nameP = c.String(),
                        price = c.Int(nullable: false),
                        qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
