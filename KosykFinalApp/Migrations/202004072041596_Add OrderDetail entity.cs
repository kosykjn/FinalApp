namespace KosykFinalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderDetailentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductOrders", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductOrders", "Order_Id", "dbo.Orders");
            DropIndex("dbo.ProductOrders", new[] { "Product_Id" });
            DropIndex("dbo.ProductOrders", new[] { "Order_Id" });
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Order_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Product_Id);
            
            DropTable("dbo.ProductOrders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Order_Id });
            
            DropForeignKey("dbo.OrderDetails", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "Product_Id" });
            DropIndex("dbo.OrderDetails", new[] { "Order_Id" });
            DropTable("dbo.OrderDetails");
            CreateIndex("dbo.ProductOrders", "Order_Id");
            CreateIndex("dbo.ProductOrders", "Product_Id");
            AddForeignKey("dbo.ProductOrders", "Order_Id", "dbo.Orders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductOrders", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
