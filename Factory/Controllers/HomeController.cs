using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    
        public HomeController(FactoryContext db)
    {
      _db = db;
    }

  

        [HttpGet("/")]
    public ActionResult Index(object Engineers, object Machines)
    {
      List<object> model = new List< object>();
      model.Add(Engineers);
      model.Add(Machines);
      return View(model);
    }
  }
}