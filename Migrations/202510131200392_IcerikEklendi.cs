namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IcerikEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Icerik", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Icerik");
        }
    }
}
