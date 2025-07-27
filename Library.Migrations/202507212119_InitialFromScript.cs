using FluentMigrator;

namespace Library.Migrations
{
    //just for sample
    //[Migration(202507212119)]
    public class _202507212119_InitialFromScript : Migration
    {
        public override void Up()
        {
            Execute.Script("InitialTables.sql");
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
