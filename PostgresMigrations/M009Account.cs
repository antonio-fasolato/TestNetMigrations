using System;
using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(9)]
    public class M009Account : Migration
    {
        public override void Up()
        {
            Create.Table("account")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("firstname").AsString().Nullable()
                .WithColumn("lastname").AsString().Nullable()
                .WithColumn("companyname").AsString().Nullable()
                .WithColumn("language").AsString().Nullable()
                .WithColumn("email").AsString().Nullable()
                .WithColumn("phone").AsString().Nullable()
                .WithColumn("name").AsString().Nullable()
                .WithColumn("username").AsString().Nullable()
                .WithColumn("userrole").AsString().Nullable()
                .WithColumn("password").AsString().Nullable()
                .WithColumn("enabled").AsBoolean().Nullable()
                .WithColumn("sequentialid").AsInt16().Nullable()
                .WithColumn("anagraphicid").AsGuid().Nullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("account");
        }
    }
}