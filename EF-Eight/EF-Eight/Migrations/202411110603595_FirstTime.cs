namespace EF_Eight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TouristPlaces",
                c => new
                    {
                        TouristPlaceId = c.Int(nullable: false, identity: true),
                        TouristPlaceName = c.String(),
                        Description = c.String(),
                        Location = c.Geography(),
                    })
                .PrimaryKey(t => t.TouristPlaceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TouristPlaces");
        }
    }
}
