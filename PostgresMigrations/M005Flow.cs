using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(5)]
    public class M005Flow : Migration
    {
        public override void Up()
        {
            Create.Table("flow")
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
            Delete.Table("flow");
        }
    }
}