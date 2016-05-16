using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(15)]
    public class M015PaymentTransaction : Migration
    {
        public override void Up()
        {
            Create.Table("paymenttransaction")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("transactioncode").AsGuid().NotNullable()
                .WithColumn("flowid").AsGuid().Nullable()
                .WithColumn("serializedrequest").AsString().NotNullable()
                .WithColumn("serializedresponse").AsString().NotNullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("paymenttransaction");
        }
    }
}