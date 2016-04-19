namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fluentapiimplementation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Users", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.UserTypes", "UserTypeName", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserTypes", "UserTypeName", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
        }
    }
}
