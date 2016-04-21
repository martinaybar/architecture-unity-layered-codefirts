namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RowVersionforUsertable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RowVersion", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RowVersion");
        }
    }
}
