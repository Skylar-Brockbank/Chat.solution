using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}