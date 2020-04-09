namespace KosykFinalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAdminEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Admins", "User_Id", "dbo.Users");
            DropIndex("dbo.Admins", new[] { "User_Id" });
            DropTable("dbo.Admins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Admins", "User_Id");
            AddForeignKey("dbo.Admins", "User_Id", "dbo.Users", "Id");
        }
    }
}
