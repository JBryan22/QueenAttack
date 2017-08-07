using Microsoft.AspNetCore.Mvc;
using Queens.Models;

namespace Queens.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult IndexPost()
    {
      Queen myQueen = new Queen(int.Parse(Request.Form["queen-x"]), int.Parse(Request.Form["queen-y"]));
      bool result = myQueen.CanAttack(int.Parse(Request.Form["victim-x"]), int.Parse(Request.Form["victim-y"]));

      if (result)
      {
        return View("index", "That is a valid move.");
      }
      else
      {
        return View("index", "That is not a valid move.");
      }
    }
  }
}
