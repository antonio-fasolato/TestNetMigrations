using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(18)]
    public class M018File : Migration
    {
        public override void Up()
        {
            Create.Table("file")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("filename").AsString().Nullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("file");
        }
    }
}