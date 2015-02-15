namespace MyEntertainment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TvShowModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        showId = c.Int(nullable: false),
                        poster = c.Binary(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.UserTvShowModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userID = c.String(),
                        timeZone = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTvShowModels");
            DropTable("dbo.TvShowModels");
        }
    }
}
