using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Engineer.Controllers
{
    public class EngineersController : Controller
    {
        private readonly FactoryContext _db;

        public EngineersController(FactoryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Engineers.ToList());

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Engineer engineer)
        {
            _db.Engineers.Add(engineer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Engineer thisEngineer = _db.Engineers
              .Include(fish => fish.JoinEntities)
              .ThenInclude(fish => fish.Machine)
              .FirstOrDefault(fish => fish.EngineerId == id);
            return View(thisEngineer);
        }

        public ActionResult AddMachineEngineer(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(Engineer => Engineers.EngineerId == id);
            ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "MachineName");
            return View(thisEngineer);
        }

        [HttpPost]
        public ActionResult AddMachineEngineer(Engineer engineer, int MachineId)
        {
#nullable enable
            MachineEngineer? joinEntity = _db.MachineEngineers.FirstOrDefault(join => (join.MachineId == MachineId && join.EngineerId == engineer.EngineerId));
#nullable disable
            if (joinEntity == null && MachineId != 0)
            {
                _db.MachineEngineers.Add(new MachineEngineer() { MachineId = MachineId, EngineerId = engineer.EngineerId });
                _db.SaveChanges();

            }

            return RedirectToAction("Details", new { id = engineer.EngineerId });
        }
        public ActionResult Delete(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(Engineer => Engineer.EngineerId == id);
            return View(thisEngineer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Engineer thisEngineer = _db.Engineers.FirstOrDefault(Engineer => Engineer.EngineerId == id);
            _db.Engineers.Remove(thisEngineer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
