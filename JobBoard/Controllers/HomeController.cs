using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
  public class HomeController : Controllers
  {
    [HttsGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}