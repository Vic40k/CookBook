namespace CookBook.RecipeDB {
    export interface RecipeForm {
        EntryDate: Serenity.DateEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        PrimaryImage: Serenity.StringEditor;
        Ingredients: Serenity.StringEditor;
        CookingMethod: Serenity.StringEditor;
        Recommendations: Serenity.StringEditor;
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

                Q.initFormType(RecipeForm, [
                    'EntryDate', w0,
                    'Name', w1,
                    'Description', w1,
                    'PrimaryImage', w1,
                    'Ingredients', w1,
                    'CookingMethod', w1,
                    'Recommendations', w1
                ]);
            }
        }
    }
}
