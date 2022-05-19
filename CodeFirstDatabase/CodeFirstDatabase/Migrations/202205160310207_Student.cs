namespace CodeFirstDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Employees_emId", c => c.Int());
            CreateIndex("dbo.Orders", "Employees_emId");
            AddForeignKey("dbo.Orders", "Employees_emId", "dbo.Employees", "emId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Employees_emId", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "Employees_emId" });
            DropColumn("dbo.Orders", "Employees_emId");
        }
    }
}
