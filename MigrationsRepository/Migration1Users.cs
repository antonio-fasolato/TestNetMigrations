using FluentMigrator;

namespace MigrationsRepository
{
    [Migration(1)]
    public class Migration1Users : Migration
    {
        public override void Up()
        {
            Create.Table("users")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("name").AsString().NotNullable()
                .WithColumn("password").AsString().NotNullable();

            Create.Index().OnTable("users").OnColumn("name").Ascending().WithOptions().Unique();

            Insert.IntoTable("users").Row(new {name = "admin", password = "admin"});
        }

        public override void Down()
        {
            Delete.Table("users");
        }
    }
}