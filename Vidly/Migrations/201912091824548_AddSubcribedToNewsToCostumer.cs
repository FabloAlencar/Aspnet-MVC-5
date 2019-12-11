namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddSubcribedToNewsToCostumer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubcraibedToNewsletter", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubcraibedToNewsletter");
        }
    }
}