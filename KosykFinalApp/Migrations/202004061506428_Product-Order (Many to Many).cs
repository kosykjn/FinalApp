namespace KosykFinalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductOrderManytoMany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Order_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.ProductOrders", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductOrders", new[] { "Order_Id" });
            DropIndex("dbo.ProductOrders", new[] { "Product_Id" });
            DropTable("dbo.ProductOrders");
        }
    }
}
