namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO movies (Name, GenreId, Stock, ReleaseDate, DateAdded) VALUES ('Spider-Man: No Way Home',8,15,'15-12-2021','03-01-2020')");
            Sql("INSERT INTO movies (Name, GenreId, Stock, ReleaseDate, DateAdded) VALUES ('The Man Who Knew Infinity',2,6,'17-06-2015','25-03-2017')");
            Sql("INSERT INTO movies (Name, GenreId, Stock, ReleaseDate, DateAdded) VALUES ('Contagion',4,2,'05-10-2011','18-12-2011')");
        }
        
        public override void Down()
        {
            Sql("Delete from movies");
        }
    }
}
