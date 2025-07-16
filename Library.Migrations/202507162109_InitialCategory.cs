using FluentMigrator;

namespace Library.Migrations
{
    [Migration(202507162109)]
    public class _202507162109_InitialCategory : Migration
    {
        public override void Up()
        {
            Create.Table("Categories")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Title").AsString(50).NotNullable().Unique();
        }

        public override void Down()
        {
            Delete.Table("Categories");
        }
    }
}
