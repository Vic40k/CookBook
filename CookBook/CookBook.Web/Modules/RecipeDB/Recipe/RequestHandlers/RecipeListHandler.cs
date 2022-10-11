using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CookBook.RecipeDB.RecipeRow>;
using MyRow = CookBook.RecipeDB.RecipeRow;

namespace CookBook.RecipeDB
{
    public interface IRecipeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeListHandler
    {
        public RecipeListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}