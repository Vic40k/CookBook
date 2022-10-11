using Serenity.Navigation;
using MyPages = CookBook.RecipeDB.Pages;

[assembly: NavigationLink(int.MaxValue, "Книга рецептов/Рецепты", typeof(MyPages.RecipeController), icon: "fa-newspaper-o")]