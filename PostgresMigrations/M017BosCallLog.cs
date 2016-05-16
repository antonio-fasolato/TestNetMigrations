using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(17)]
    public class M017BosCallLog:Migration
    {
        public override void Up()
        {
            Create.Table("boscalllog")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("transactionid").AsGuid().Nullable()
                .WithColumn("xmlinput").AsString().Nullable()
                .WithColumn("xmloutput").AsString().Nullable()
                .WithColumn("calltype").AsInt32().Nullable()
                .WithColumn("calltypedescription").AsString().Nullable()
                .WithColumn("bosuser").AsString().Nullable()
                .WithColumn("bospassword").AsString().Nullable()
                .WithColumn("bosworkstation").AsString().Nullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("boscalllog");
        }
    }
}