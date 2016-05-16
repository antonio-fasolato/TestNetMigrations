using FluentMigrator;

namespace PostgresMigrations
{
    [Migration(14)]
    public class M014Coupon:Migration
    {
        public override void Up()
        {
            Create.Table("coupon")
                .WithColumn("id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("key").AsString().NotNullable()
                .WithColumn("exhibitionid").AsGuid().NotNullable()
                .WithColumn("redeemed").AsBoolean().NotNullable()
                .WithColumn("redeemedat").AsDateTime().Nullable()
                .WithColumn("createdat").AsDateTime()
                .WithColumn("changedat").AsDateTime()
                .WithColumn("createdby").AsString()
                .WithColumn("changedby").AsString()
                .WithColumn("serializeddto").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("coupon");
        }
    }
}