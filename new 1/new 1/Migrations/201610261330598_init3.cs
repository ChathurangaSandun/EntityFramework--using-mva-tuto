namespace new_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviewers",
                c => new
                    {
                        ReviwerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ReviwerID);
            
            CreateTable(
                "dbo.ReviewersAlbums",
                c => new
                    {
                        Reviewers_ReviwerID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reviewers_ReviwerID, t.Album_AlbumID })
                .ForeignKey("dbo.Reviewers", t => t.Reviewers_ReviwerID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Reviewers_ReviwerID)
                .Index(t => t.Album_AlbumID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReviewersAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.ReviewersAlbums", "Reviewers_ReviwerID", "dbo.Reviewers");
            DropIndex("dbo.ReviewersAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.ReviewersAlbums", new[] { "Reviewers_ReviwerID" });
            DropTable("dbo.ReviewersAlbums");
            DropTable("dbo.Reviewers");
        }
    }
}
