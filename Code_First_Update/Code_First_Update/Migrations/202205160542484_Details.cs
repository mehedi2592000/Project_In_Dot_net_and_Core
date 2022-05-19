namespace Code_First_Update.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orderdetails",
                c => new
                    {
                        Did = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        money = c.Int(nullable: false),
                        OrdeId = c.Int(nullable: false),
                        Order_OId = c.Int(),
                    })
                .PrimaryKey(t => t.Did)
                .ForeignKey("dbo.Orders", t => t.Order_OId)
                .Index(t => t.Order_OId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OId = c.Int(nullable: false, identity: true),
                        Oname = c.String(),
                        Taka = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        
                })
                .PrimaryKey(t => t.OId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orderdetails", "Order_OId", "dbo.Orders");
            DropIndex("dbo.Orderdetails", new[] { "Order_OId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Orderdetails");
        }
    }
}
