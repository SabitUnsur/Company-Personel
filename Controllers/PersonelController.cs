using CompanyCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CompanyCore.Controllers
{
	//Include:İlişkili tablo verilerini çeker.

	public class PersonelController : Controller
    {
        Context db = new Context();

		[Authorize]
		public IActionResult Index()
        {
            var values = db.Personels.Include(p=>p.Unit).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewPersonel()
        {
            List<SelectListItem> values = (from p in db.Units.ToList()
                                           select new SelectListItem
                                           {
                                               Text = p.UnitName,
                                               Value = p.UnitID.ToString(),
                                           }).ToList();
            ViewBag.value = values;

            return View("NewPersonel");
        }

        [HttpPost]
        public IActionResult AddNewPersonel(Personel personel)
        {
           var per=db.Units.Where(p=>p.UnitID==personel.Unit.UnitID).FirstOrDefault();
            personel.Unit = per;
            db.Personels.Add(personel);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }






    }
}
