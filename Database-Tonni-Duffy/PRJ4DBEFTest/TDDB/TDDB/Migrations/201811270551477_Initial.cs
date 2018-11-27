namespace TDDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maps",
                c => new
                    {
                        MapName = c.String(nullable: false, maxLength: 128),
                        MapScore = c.Int(nullable: false),
                        Score_ScoreID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.MapName)
                .ForeignKey("dbo.Scores", t => t.Score_ScoreID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Score_ScoreID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        TotalHighscore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ScoreID = c.Int(nullable: false, identity: true),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScoreID)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Maps", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Scores", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Maps", "Score_ScoreID", "dbo.Scores");
            DropIndex("dbo.Scores", new[] { "User_UserID" });
            DropIndex("dbo.Maps", new[] { "User_UserID" });
            DropIndex("dbo.Maps", new[] { "Score_ScoreID" });
            DropTable("dbo.Scores");
            DropTable("dbo.Users");
            DropTable("dbo.Maps");
        }
    }
}
