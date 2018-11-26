using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string adjective1, string adjective2,string hobbie1, string hobbie2, string hobbie3, string food)
    {
      MadLibVariable newMadLibVariable = new MadLibVariable(adjective1, adjective2, hobbie1, hobbie2, hobbie3, food);
      return View(newMadLibVariable);
    }
  }
}
