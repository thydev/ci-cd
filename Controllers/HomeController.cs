using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ci.Models;

namespace ci.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    [Route("ShowPicture")]
    public IActionResult ShowPicture()
    {
      ViewData["Message"] = "Show beach picture.";

      return View("ShowPicture");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
