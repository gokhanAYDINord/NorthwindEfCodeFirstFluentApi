namespace NorthwindEfCodeFirstFluentApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestColumnUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Test", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Test");
        }
    }
}
