using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(4)]
    public class M004FlowConfig : Migration
    {
        public override void Up()
        {
            Create.Table("flowconfig")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("exhibitionid").AsGuid().NotNullable()
                .WithColumn("entrypoint").AsString().NotNullable()
                .WithColumn("invalid").AsBoolean().NotNullable()
                .WithColumn("invalidatedat").AsDateTime().Nullable()
                .WithColumn("externaldmgcategory").AsString().Nullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("flowconfig");
        }
    }
}