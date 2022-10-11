
namespace CookBook.RecipeDB {

    @Serenity.Decorators.registerClass()
    export class RecipeDialog extends Serenity.EntityDialog<RecipeRow, any> {
        protected getFormKey() { return RecipeForm.formKey; }
        protected getIdProperty() { return RecipeRow.idProperty; }
        protected getLocalTextPrefix() { return RecipeRow.localTextPrefix; }
        protected getNameProperty() { return RecipeRow.nameProperty; }
        protected getService() { return RecipeService.baseUrl; }
        protected getDeletePermission() { return RecipeRow.deletePermission; }
        protected getInsertPermission() { return RecipeRow.insertPermission; }
        protected getUpdatePermission() { return RecipeRow.updatePermission; }

        protected form = new RecipeForm(this.idPrefix);

    }
}