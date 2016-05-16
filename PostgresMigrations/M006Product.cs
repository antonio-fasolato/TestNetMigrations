using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(6)]
    public class M006Product : Migration
    {
        public override void Up()
        {
            Create.Table("product")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("exhibitionid").AsGuid().NotNullable()
                .WithColumn("flowconfigid").AsGuid().NotNullable()
                .WithColumn("invalid").AsBoolean().NotNullable()
                .WithColumn("invalidatedat").AsDateTime().Nullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("product");
        }
    }
}