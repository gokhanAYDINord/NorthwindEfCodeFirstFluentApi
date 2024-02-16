namespace NorthwindEfCodeFirstFluentApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCoolumnTypeTestColumnUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Test", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Test", c => c.String());
        }
    }
}
