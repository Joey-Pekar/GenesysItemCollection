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
    public class WeaponController : Controller
    {

        private readonly WeaponService _weapons;

        public WeaponController(WeaponService weaponService)
        {

            _weapons = weaponService;

        }

        // GET: Weapon
        public ActionResult Index()
        {
            return View(_weapons.Get());
        }

        // GET: Weapon/Details/5
        public ActionResult Details(string id)
        {

            var weapon = _weapons.Get(id);

            if (weapon == null)
            {

                return NotFound();

            }


            return View(weapon);
        }

        // GET: Weapon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Weapon/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Weapon weapon)
        {

            List<string> qualities = new List<string>();



            foreach (string quality in weapon.special)
            {

                if (quality != "NULL")
                {
                    qualities.Add(quality);
                }

            }

            weapon.special = qualities;

            if (ModelState.IsValid)
            {
                _weapons.Create(weapon);
                return RedirectToAction(nameof(Index));
            }

            return View(weapon);
        }

    }
}