namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateEditAMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "AddedDate");
        }

        public override void Down()
        {
            AddColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}