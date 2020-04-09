namespace KosykFinalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Multiplyupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "LastName", c => c.String());
            AddColumn("dbo.Admins", "Address", c => c.String());
            AddColumn("dbo.Admins", "Email", c => c.String());
            AddColumn("dbo.Admins", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "Address", c => c.String());
            AddColumn("dbo.Customers", "Email", c => c.String());
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Managers", "LastName", c => c.String());
            AddColumn("dbo.Managers", "Address", c => c.String());
            AddColumn("dbo.Managers", "Email", c => c.String());
            AddColumn("dbo.Managers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Managers", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Managers", "Status");
            DropColumn("dbo.Managers", "DateOfBirth");
            DropColumn("dbo.Managers", "Email");
            DropColumn("dbo.Managers", "Address");
            DropColumn("dbo.Managers", "LastName");
            DropColumn("dbo.Products", "CreateDate");
            DropColumn("dbo.Orders", "CreateDate");
            DropColumn("dbo.Customers", "DateOfBirth");
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Admins", "DateOfBirth");
            DropColumn("dbo.Admins", "Email");
            DropColumn("dbo.Admins", "Address");
            DropColumn("dbo.Admins", "LastName");
        }
    }
}
