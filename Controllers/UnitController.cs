using CompanyCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyCore.Controllers
{
    public class UnitController : Controller
    {
        Context db = new Context();
        public IActionResult Index()
        {
            var values = db.Units.ToList();
            return View(values);
        }
       
        [HttpGet]
        public IActionResult NewUnit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewUnit(Unit newUnit)
        {
            var unitToAdd = db.Units.Add(newUnit);
            db.SaveChanges();
            return RedirectToAction("Index",unitToAdd);
        }

        public IActionResult DeleteUnit(int unitID)
        {
            var unitToDelete = db.Units.Find(unitID);
            db.Units.Remove(unitToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult GetUnits(int unitID)
        {
            var unitToGet = db.Units.Find(unitID);
            return View("GetUnits", unitToGet);
        }

        [HttpPost]
        public IActionResult UpdateUnit(Unit unit)
        {
            var unitToUpdate = db.Units.Find(unit.UnitID);
            unitToUpdate.UnitName = unit.UnitName;
            db.Update(unitToUpdate);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetUnitDetails(int unitID)
        {
            var values=db.Personels.Where(p=>p.UnitID== unitID).ToList();
            var unitName = db.Units.Where(u => u.UnitID == unitID).Select(u => u.UnitName)
                .FirstOrDefault();

            ViewBag.unitName = unitName;

            return View(values);
        }
      



    }
}
