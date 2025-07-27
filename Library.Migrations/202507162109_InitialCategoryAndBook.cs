using FluentMigrator;
using System.Data;

namespace Library.Migrations
{
    [Migration(202507162109)]
    public class _202507162109_InitialCategoryAndBook : Migration
    {
        public override void Up()
        {
            Create
                .Table("Categories")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Title").AsString(125).NotNullable().Unique()
                .WithColumn("AgeRange").AsInt32().NotNullable();

            Create.Table("Books")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Quantity").AsInt32().NotNullable()
                .WithColumn("PageCount").AsInt32().NotNullable()
                .WithColumn("Title").AsString(125).NotNullable()
                .WithColumn("Description").AsString(500).Nullable()
                .WithColumn("PublishDate").AsDateTime2().NotNullable()
                .WithColumn("CategoryId").AsInt32().NotNullable();

            Create.ForeignKey("FK_Books_Categories")
                .FromTable("Books")
                .ForeignColumn("CategoryId")
                .ToTable("Categories")
                .PrimaryColumn("Id")
                .OnDeleteOrUpdate(Rule.None);
        }

        public override void Down()
        {
            Delete.Table("Books");
            Delete.Table("Categories");
        }
    }
}
