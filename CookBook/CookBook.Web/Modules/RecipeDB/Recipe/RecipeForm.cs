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
        public string Description { get; set; }
        public string PrimaryImage { get; set; }
        public string Ingredients { get; set; }
        public string CookingMethod { get; set; }
        public string Recommendations { get; set; }
    }
}