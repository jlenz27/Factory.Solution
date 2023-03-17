using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
        private object engineers;
        private object machines;

        public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      
      List<object> model = new List< object>();
      model.Add(engineers);
      model.Add( machines);
      return View(model);
    }
  }
}