using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(19)]
    public class M019Ticket:Migration
    {
        public override void Up()
        {
            Create.Table("ticket")
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
            Delete.Table("ticket");
        }
    }
}