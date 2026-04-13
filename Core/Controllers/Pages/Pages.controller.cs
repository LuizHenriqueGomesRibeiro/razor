



using Microsoft.AspNetCore.Mvc;

public class PagesController: Controller {
  public PagesController() {
    
  }

  public IActionResult Index() {
    return View("~/Views/Index.cshtml");
  }

  [HttpGet("/Home")]
  public IActionResult Home() {
    return View("~/Views/Home/Index.cshtml");
  }
}