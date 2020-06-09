﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenesysItemCollection.Models;
using GenesysItemCollection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenesysItemCollection.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponApiController : ControllerBase
    {

        private readonly WeaponService _weaponService;

        public WeaponApiController(WeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpGet]
        public ActionResult<List<Weapon>> Get()
        {

            return _weaponService.Get();

        }

        [HttpGet("{id:length(24)}", Name = "GetWeapon")]
        public ActionResult<Weapon> Get(string id)
        {
            var weapon = _weaponService.Get(id);

            if (weapon == null)
            {
                return NotFound();
            }

            return weapon;
        }

        [HttpGet("{name}", Name = "GetWeaponByName")]
        public ActionResult<Weapon> GetByName(string name)
        {
            var weapon = _weaponService.Get().Where(w => w.name.Equals(name)).FirstOrDefault();

            if (weapon == null)
            {
                return NotFound();
            }

            return weapon;

        }

        [HttpGet("skill/{skill}", Name = "GetWeaponsBySkill")]
        public ActionResult<List<Weapon>> GetByType(string skill)
        {
            var weapons = _weaponService.Get().Where(w => string.Equals(w.skill, skill, StringComparison.OrdinalIgnoreCase)).ToList();

            if (weapons == null)
            {
                return NotFound();
            }

            return weapons;
        }



    }
}