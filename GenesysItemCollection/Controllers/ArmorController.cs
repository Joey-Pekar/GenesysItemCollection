using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        // GET: Armor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Armor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Armor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Armor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Armor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Armor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Armor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}