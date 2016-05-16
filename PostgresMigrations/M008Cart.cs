using System;
using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(8)]
    public class M008Cart : Migration
    {
        public override void Up()
        {
            Create.Table("cart")
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
            Delete.Table("cart");
        }
    }
}