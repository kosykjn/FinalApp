namespace KosykFinalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRole : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "Role_Id" });
            AddColumn("dbo.Users", "Role", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Role_Id");
            DropTable("dbo.Roles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "Role_Id", c => c.Int());
            DropColumn("dbo.Users", "Role");
            CreateIndex("dbo.Users", "Role_Id");
            AddForeignKey("dbo.Users", "Role_Id", "dbo.Roles", "Id");
        }
    }
}
