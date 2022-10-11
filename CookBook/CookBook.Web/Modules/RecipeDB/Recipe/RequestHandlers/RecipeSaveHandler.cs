using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<CookBook.RecipeDB.RecipeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CookBook.RecipeDB.RecipeRow;

namespace CookBook.RecipeDB
{
    public interface IRecipeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RecipeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRecipeSaveHandler
    {
        public RecipeSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}