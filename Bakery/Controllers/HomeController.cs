using Bakery.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryContext _db;
    public HomeController(BakeryContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }
  }
}