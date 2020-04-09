namespace KosykFinalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatustoOrderRemoveStatusfromManager : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Managers", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Managers", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Status");
        }
    }
}
