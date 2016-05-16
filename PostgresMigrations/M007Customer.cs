using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(7)]
    public class M007Customer : Migration
    {
        public override void Up()
        {
            Create.Table("customer")
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
            Delete.Table("customer");
        }
    }
}