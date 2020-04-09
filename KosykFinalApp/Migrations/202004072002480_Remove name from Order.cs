namespace KosykFinalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovenamefromOrder : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Name", c => c.String());
        }
    }
}
