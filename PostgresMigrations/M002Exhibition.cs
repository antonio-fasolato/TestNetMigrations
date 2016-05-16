using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(2)]
    public class M002Exhibition:Migration
    {
        public override void Up()
        {
            Create.Table("exhibition")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("name").AsString().NotNullable()
                .WithColumn("code").AsString().NotNullable()
                .WithColumn("fairid").AsGuid().NotNullable()
                .WithColumn("invalid").AsBoolean().NotNullable()
                .WithColumn("invalidatedat").AsDateTime().Nullable()
                .WithColumn("externaleventid").AsString().Nullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();

        }

        public override void Down()
        {
            Delete.Table("exhibition");
        }
    }
}