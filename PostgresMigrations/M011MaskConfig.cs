using System;
using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(11)]
    public class M011MaskConfig : Migration
    {
        public override void Up()
        {
            Create.Table("maskconfig")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("flowconfigid").AsGuid().NotNullable().WithDefaultValue(Guid.Empty)
                .WithColumn("productid").AsGuid().NotNullable().WithDefaultValue(Guid.Empty)
                .WithColumn("order").AsInt64().NotNullable()
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
            Delete.Table("maskconfig");
        }
    }
}