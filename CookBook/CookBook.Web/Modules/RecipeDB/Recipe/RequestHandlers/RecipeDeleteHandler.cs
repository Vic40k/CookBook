using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CookBook.RecipeDB.RecipeRow;

namespace CookBook.RecipeDB
{
    public interface IRecipeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeDeleteHandler
    {
        public RecipeDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}