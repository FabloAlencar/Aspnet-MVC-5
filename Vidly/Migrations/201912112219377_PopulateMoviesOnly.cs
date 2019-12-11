namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesOnly : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, ReleaseDate, AddedDate, NumberInStock, GenreId) VALUES ('Hangover'      ,'05/06/1991 08:45:03','11/12/2019 08:45:03',5,9)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, AddedDate, NumberInStock, GenreId) VALUES ('Die Hard'      ,'05/06/1992 08:45:03','11/12/2019 08:45:03',5,10)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, AddedDate, NumberInStock, GenreId) VALUES ('The Terminator','05/06/1993 08:45:03','11/12/2019 08:45:03',5,10)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, AddedDate, NumberInStock, GenreId) VALUES ('Toy Story'     ,'05/06/1994 08:45:03','11/12/2019 08:45:03',5,11)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, AddedDate, NumberInStock, GenreId) VALUES ('Titanic'       ,'05/06/1995 08:45:03','11/12/2019 08:45:03',5,12)");
        }
        
        public override void Down()
        {
        }
    }
}
