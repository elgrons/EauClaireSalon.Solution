using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      // [Route("/favorite_photos")]
      // public ActionResult FavoritePhotos()
      // {
      //   return View();
      // }

    }
}