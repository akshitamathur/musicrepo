namespace Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNullDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musics", "ReleaseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musics", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
