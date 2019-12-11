namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies_and_Genres1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));


            Sql("INSERT INTO Genres ( Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres ( Name) VALUES ('Action')");
            Sql("INSERT INTO Genres ( Name) VALUES ('Family')");
            Sql("INSERT INTO Genres ( Name) VALUES ('Romance')");


        }

        public override void Down()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String());
        }
    }
}
