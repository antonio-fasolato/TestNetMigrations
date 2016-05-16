using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(16)]
    public class M016FlowConfigTemplate:Migration
    {
        public override void Up()
        {
            Create.Table("flowconfigtemplate")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("exhibitionid").AsGuid().NotNullable()
                .WithColumn("entrypoint").AsString().Nullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("flowconfigtemplate");
        }
    }
}