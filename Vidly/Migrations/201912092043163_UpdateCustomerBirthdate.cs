namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = null  WHERE Id = 1 ");
            Sql("UPDATE Customers SET Birthdate = '05/06/1994 08:45:03'  WHERE Id = 2 ");
        }

        public override void Down()
        {
        }
    }
}