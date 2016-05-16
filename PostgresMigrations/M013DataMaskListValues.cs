using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(13)]
    public class M013DataMaskListValues : Migration
    {
        public override void Up()
        {
            Create.Table("datamasklistvalues")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("externalcode").AsString().NotNullable().WithDefaultValue("")
                .WithColumn("order").AsInt16().NotNullable()
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
            Delete.Table("datamasklistvalues");
        }
    }
}