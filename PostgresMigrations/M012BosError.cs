using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(12)]
    public class M012BosError : Migration
    {
        public override void Up()
        {
            Create.Table("boserror")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("errordate").AsDateTime().NotNullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("boserror");
        }
    }
}