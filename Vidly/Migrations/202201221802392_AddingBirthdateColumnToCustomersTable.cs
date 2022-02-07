namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBirthdateColumnToCustomersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
            Sql("UPDATE Customers SET Birthdate = '15/05/1990' WHERE id=1");
            Sql("UPDATE Customers SET Birthdate = '22/07/1994' WHERE id=2");
            Sql("UPDATE Customers SET Birthdate = '01/01/1980' WHERE id=3");
            Sql("UPDATE Customers SET Birthdate = '01/01/1980' WHERE id=4");
            Sql("UPDATE Customers SET Birthdate = '01/01/1980' WHERE id=5");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
            Sql("UPDATE Customers SET Birthdate = null WHERE id=1");
            Sql("UPDATE Customers SET Birthdate = null WHERE id=2");
            Sql("UPDATE Customers SET Birthdate = null WHERE id=3");
            Sql("UPDATE Customers SET Birthdate = null WHERE id=4");
            Sql("UPDATE Customers SET Birthdate = null WHERE id=5");
        }
    }
}
