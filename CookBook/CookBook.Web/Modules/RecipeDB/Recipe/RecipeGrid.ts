
namespace CookBook.RecipeDB {

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
    }
}