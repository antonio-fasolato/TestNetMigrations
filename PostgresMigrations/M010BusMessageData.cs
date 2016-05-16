using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(10)]
    public class M010BusMessageData : Migration
    {
        public override void Up()
        {
            Create.Table("busmessage")
                .WithColumn("eventinterface").AsString().NotNullable()
                .WithColumn("processbeforeat").AsDateTime().NotNullable()
                .WithColumn("status").AsInt16().NotNullable()
                .WithColumn("timeelapsed").AsInt64().NotNullable()
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("exhibitionid").AsGuid().NotNullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("busmessage");
        }
    }
}