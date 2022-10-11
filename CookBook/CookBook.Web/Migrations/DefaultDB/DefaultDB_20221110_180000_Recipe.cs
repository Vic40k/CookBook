using FluentMigrator;
using Serenity.Extensions;

namespace CookBook.Migrations.DefaultDB
{
    [Migration(20221110180000)]
    public class DefaultDB_20221110_180000_Recipe : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Recipes", "Id", s => s
                .WithColumn("EntryDate").AsDateTime().NotNullable()
                .WithColumn("Name").AsString(200).NotNullable()
                .WithColumn("Description").AsString(200).NotNullable()
                .WithColumn("Image").AsBinary().NotNullable()
                .WithColumn("Ingredients").AsString(2000)
                .WithColumn("CookingMethod").AsString(2000)
                .WithColumn("Recommendations").AsString(200));

            Create.Index("UX_Recipes_UID_Recipes_Name")
                .OnTable("Recipes")
                .OnColumn("Id").Ascending()
                .OnColumn("Name").Ascending()
                .WithOptions().Unique();
        }

    }
}