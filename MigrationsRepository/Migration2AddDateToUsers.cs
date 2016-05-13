using FluentMigrator;

namespace MigrationsRepository
{
    [Migration(2)]
    public class Migration2AddDateToUsers : Migration
    {
        public override void Up()
        {
            Alter.Table("users").AddColumn("birthdate").AsDate().Nullable();
        }

        public override void Down()
        {
            Delete.Column("birthdate").FromTable("users");
        }
    }
}