using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(3)]
    public class M003Fair : Migration
    {
        public override void Up()
        {
            Create.Table("fair")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("tenantid").AsGuid().NotNullable()
                .WithColumn("name").AsString().NotNullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("fair");
        }
    }
}