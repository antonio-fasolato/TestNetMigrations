using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(1)]
    public class M001Tenant : Migration
    {
        public override void Up()
        {
            Create.Table("tenant")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("urldomain").AsString().NotNullable()
                .WithColumn("enabled").AsBoolean()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("tenant");
        }
    }
}