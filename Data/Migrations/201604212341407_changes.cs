namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "UserType_UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.ProductTypes", "User_UserId", "dbo.Users");
            DropIndex("dbo.Products", new[] { "UserType_UserTypeId" });
            DropIndex("dbo.ProductTypes", new[] { "User_UserId" });
            AddColumn("dbo.Products", "ProductType_ProductTypeId", c => c.Int());
            AddColumn("dbo.Users", "ProductType_ProductTypeId", c => c.Int());
            CreateIndex("dbo.Products", "ProductType_ProductTypeId");
            CreateIndex("dbo.Users", "ProductType_ProductTypeId");
            AddForeignKey("dbo.Users", "ProductType_ProductTypeId", "dbo.ProductTypes", "ProductTypeId");
            AddForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes", "ProductTypeId");
            DropColumn("dbo.Products", "UserType_UserTypeId");
            DropColumn("dbo.ProductTypes", "User_UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductTypes", "User_UserId", c => c.Int());
            AddColumn("dbo.Products", "UserType_UserTypeId", c => c.Int());
            DropForeignKey("dbo.Products", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.Users", "ProductType_ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Users", new[] { "ProductType_ProductTypeId" });
            DropIndex("dbo.Products", new[] { "ProductType_ProductTypeId" });
            DropColumn("dbo.Users", "ProductType_ProductTypeId");
            DropColumn("dbo.Products", "ProductType_ProductTypeId");
            CreateIndex("dbo.ProductTypes", "User_UserId");
            CreateIndex("dbo.Products", "UserType_UserTypeId");
            AddForeignKey("dbo.ProductTypes", "User_UserId", "dbo.Users", "UserId");
            AddForeignKey("dbo.Products", "UserType_UserTypeId", "dbo.UserTypes", "UserTypeId");
        }
    }
}
