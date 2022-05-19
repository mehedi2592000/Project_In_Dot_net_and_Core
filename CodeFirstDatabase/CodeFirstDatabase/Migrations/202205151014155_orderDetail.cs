namespace CodeFirstDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDelails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        orderid = c.Int(nullable: false),
                        ordername = c.String(),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderDelails");
        }
    }
}
