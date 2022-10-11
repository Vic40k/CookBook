using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace CookBook.RecipeDB.Forms
{
    [FormScript("RecipeDB.Recipe")]
    [BasedOnRow(typeof(RecipeRow), CheckNames = true)]
    public class RecipeForm
    {
        public DateTime EntryDate { get; set; }
        public string Name { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string Description { get; set; }
        public string PrimaryImage { get; set; }
        [TextAreaEditor(Rows = 8)]
        public string Ingredients { get; set; }
        [TextAreaEditor(Rows = 8)]
        public string CookingMethod { get; set; }
        [TextAreaEditor(Rows = 8)]
        public string Recommendations { get; set; }
    }
}