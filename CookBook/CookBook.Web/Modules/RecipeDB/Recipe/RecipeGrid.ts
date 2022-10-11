
namespace CookBook.RecipeDB {

    import fld = RecipeRow.Fields;

    @Serenity.Decorators.registerClass()
    export class RecipeGrid extends Serenity.EntityGrid<RecipeRow, any> {
        protected getColumnsKey() { return RecipeColumns.columnsKey; }
        protected getDialogType() { return RecipeDialog; }
        protected getIdProperty() { return RecipeRow.idProperty; }
        protected getInsertPermission() { return RecipeRow.insertPermission; }
        protected getLocalTextPrefix() { return RecipeRow.localTextPrefix; }
        protected getService() { return RecipeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            return [
                { name: "", title: "везде" },
                { name: "fld.Name", title: "наименование" },
                { name: "fld.Description", title: "описание" },
                { name: "fld.Ingredients", title: "ингоидиенты" },
                { name: "fld.CookingMethod", title: "приготовление" },
                { name: "fld.Recommendations", title: "рекомендации к приёму" },
            ];
        }
    }
}