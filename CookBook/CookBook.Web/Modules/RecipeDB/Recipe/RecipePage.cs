using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace CookBook.RecipeDB.Pages
{

    [PageAuthorize(typeof(RecipeRow))]
    public class RecipeController : Controller
    {
        [Route("RecipeDB/Recipe")]
        public ActionResult Index()
        {
            return View("~/Modules/RecipeDB/Recipe/RecipeIndex.cshtml");
        }
    }
}