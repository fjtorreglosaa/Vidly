namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUpdatingBirthdayColumnFromCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = null WHERE id=4");
            Sql("UPDATE Customers SET Birthdate = null WHERE id=5");
        }
        
        public override void Down()
        {
            Sql("UPDATE Customers SET Birthdate = '1972-08-12' WHERE id=4");
            Sql("UPDATE Customers SET Birthdate = '1983-12-17' WHERE id=5");
        }
    }
}
