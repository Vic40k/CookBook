namespace CookBook.RecipeDB {
    export interface RecipeForm {
        EntryDate: Serenity.DateEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        PrimaryImage: Serenity.StringEditor;
        Ingredients: Serenity.TextAreaEditor;
        CookingMethod: Serenity.TextAreaEditor;
        Recommendations: Serenity.TextAreaEditor;
    }

    export class RecipeForm extends Serenity.PrefixedContext {
        static formKey = 'RecipeDB.Recipe';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RecipeForm.init)  {
                RecipeForm.init = true;

                var s = Serenity;
                var w0 = s.DateEditor;
                var w1 = s.StringEditor;
                var w2 = s.TextAreaEditor;

                Q.initFormType(RecipeForm, [
                    'EntryDate', w0,
                    'Name', w1,
                    'Description', w2,
                    'PrimaryImage', w1,
                    'Ingredients', w2,
                    'CookingMethod', w2,
                    'Recommendations', w2
                ]);
            }
        }
    }
}
