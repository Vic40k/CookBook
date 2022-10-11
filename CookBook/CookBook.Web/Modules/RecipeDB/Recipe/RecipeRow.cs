using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CookBook.RecipeDB
{
    [ConnectionKey("Default"), Module("RecipeDB"), TableName("[dbo].[Recipes]")]
    [DisplayName("Рецепты"), InstanceName("Рецепт")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RecipeRow : Row<RecipeRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty, Hidden]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Дата внесения"), NotNull]
        public DateTime? EntryDate
        {
            get => fields.EntryDate[this];
            set => fields.EntryDate[this] = value;
        }

        [DisplayName("Наименование"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Описание"), Size(200), NotNull]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Фото"), Size(200), ImageUploadEditor(FilenameFormat = "Recipe/PrimaryImage/RecipePrimaryImage_{0}_{2}")]
        public string PrimaryImage
        {
            get => fields.PrimaryImage[this];
            set => fields.PrimaryImage[this] = value;
        }

        [DisplayName("Ингидиенты"), Size(2000), NotNull]
        public string Ingredients
        {
            get => fields.Ingredients[this];
            set => fields.Ingredients[this] = value;
        }

        [DisplayName("Приготовление"), Size(2000), NotNull]
        public string CookingMethod
        {
            get => fields.CookingMethod[this];
            set => fields.CookingMethod[this] = value;
        }

        [DisplayName("Рекомендации к приёму"), Size(200), NotNull]
        public string Recommendations
        {
            get => fields.Recommendations[this];
            set => fields.Recommendations[this] = value;
        }

        public RecipeRow()
            : base()
        {
        }

        public RecipeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public DateTimeField EntryDate;
            public StringField Name;
            public StringField Description;
            public StringField PrimaryImage;
            public StringField Ingredients;
            public StringField CookingMethod;
            public StringField Recommendations;
        }
    }
}
