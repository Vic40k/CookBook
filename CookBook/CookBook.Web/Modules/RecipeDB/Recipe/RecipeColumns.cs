using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace CookBook.RecipeDB.Columns
{
    [ColumnsScript("RecipeDB.Recipe")]
    [BasedOnRow(typeof(RecipeRow), CheckNames = true)]
    public class RecipeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [Width(150), AlignCenter]
        public DateTime EntryDate { get; set; }
        [EditLink]
        public string Name { get; set; }
        public string Description { get; set; }
        public string PrimaryImage { get; set; }
        public string Ingredients { get; set; }
        public string CookingMethod { get; set; }
        [Width(200), AlignRight]
        public string Recommendations { get; set; }
    }
}