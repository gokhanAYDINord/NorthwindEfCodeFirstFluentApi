namespace NorthwindEfCodeFirstFluentApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRecordUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Adres3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Adres3");
        }
    }
}
