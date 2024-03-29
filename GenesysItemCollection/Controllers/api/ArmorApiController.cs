﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenesysItemCollection.Models;
using GenesysItemCollection.Services;
using Microsoft.AspNetCore.Mvc;

namespace GenesysItemCollection.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmorApiController : Controller
    {

        private readonly ArmorService _armorService;

        public ArmorApiController(ArmorService armorService)
        {
            _armorService = armorService;
        }

        [HttpGet]
        public ActionResult<List<Armor>> Get(int minMeleeDef = 0, int minRangeDef = 0, int minSoak = 0, int maxPrice = Int32.MaxValue)
        {

            var armor = _armorService.Get();

            armor = armor.Where(a => a.meleedefense >= minMeleeDef && a.rangeddefense >= minRangeDef && a.soak >= minSoak && a.price <= maxPrice).ToList();

            return armor;

        }

        [HttpGet("{id:length(24)}", Name = "GetArmor")]
        public ActionResult<Armor> Get(string id)
        {
            var armor = _armorService.Get(id);

            if (armor == null)
            {
                return NotFound();
            }

            return armor;
        }

        [HttpGet("{name}", Name = "GetArmorByName")]
        public ActionResult<Armor> GetByName(string name)
        {
            var armor = _armorService.Get().Where(w => w.name.Equals(name)).FirstOrDefault();

            if (armor == null)
            {
                return NotFound();
            }

            return armor;

        }
    }
}
