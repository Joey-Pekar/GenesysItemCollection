using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenesysItemCollection.Models;
using GenesysItemCollection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenesysItemCollection.Controllers
{
    public class ArmorController : Controller
    {

        private readonly ArmorService _armor;

        public ArmorController(ArmorService armorService)
        {

            _armor = armorService;

        }

        // GET: Armor
        public ActionResult Index()
        {
            return View(_armor.Get());
        }

        // GET: Weapon/Details/5
        public ActionResult Details(string id)
        {

            var armor = _armor.Get(id);

            if (armor == null)
            {

                return NotFound();

            }


            return View(armor);
        }

        // GET: Armor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Armor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Armor armor)
        {
            if (ModelState.IsValid)
            {
                _armor.Create(armor);
                return RedirectToAction(nameof(Index));
            }

            return View(armor);
        }
     
    }
}