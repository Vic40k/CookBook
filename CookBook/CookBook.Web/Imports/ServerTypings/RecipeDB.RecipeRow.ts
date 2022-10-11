namespace CookBook.RecipeDB {
    export interface RecipeRow {
        Id?: number;
        EntryDate?: string;
        Name?: string;
        Description?: string;
        PrimaryImage?: string;
        Ingredients?: string;
        CookingMethod?: string;
        Recommendations?: string;
    }

    export namespace RecipeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'RecipeDB.Recipe';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            EntryDate = "EntryDate",
            Name = "Name",
            Description = "Description",
            PrimaryImage = "PrimaryImage",
            Ingredients = "Ingredients",
            CookingMethod = "CookingMethod",
            Recommendations = "Recommendations"
        }
    }
}
