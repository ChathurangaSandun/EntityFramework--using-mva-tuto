namespace new_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtistDetails",
                c => new
                    {
                        ArtistID = c.Int(nullable: false),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID)
                .ForeignKey("dbo.Artist", t => t.ArtistID)
                .Index(t => t.ArtistID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArtistDetails", "ArtistID", "dbo.Artist");
            DropIndex("dbo.ArtistDetails", new[] { "ArtistID" });
            DropTable("dbo.ArtistDetails");
        }
    }
}
