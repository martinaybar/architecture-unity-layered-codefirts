namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addproduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        UserType_UserTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.UserTypes", t => t.UserType_UserTypeId)
                .Index(t => t.UserType_UserTypeId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductTypeId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTypes", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Products", "UserType_UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.ProductTypes", new[] { "User_UserId" });
            DropIndex("dbo.Products", new[] { "UserType_UserTypeId" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
        }
    }
}
