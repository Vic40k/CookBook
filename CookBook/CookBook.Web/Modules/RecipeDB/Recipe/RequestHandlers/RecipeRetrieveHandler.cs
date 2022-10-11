using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CookBook.RecipeDB.RecipeRow>;
using MyRow = CookBook.RecipeDB.RecipeRow;

namespace CookBook.RecipeDB
{
    public interface IRecipeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeRetrieveHandler
    {
        public RecipeRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}