
using GenesysItemCollection.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenesysItemCollection.Services
{
    public class WeaponService
    {

        private readonly IMongoCollection<Weapon> _weapons;

        public WeaponService(IDatabaseSettings settings)
        {

            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _weapons = database.GetCollection<Weapon>(settings.WeaponsCollectionName);

        }

        public List<Weapon> Get() => _weapons.Find(weapon => true).ToList();

        public Weapon Get(string id) => _weapons.Find<Weapon>(weapon => weapon.Id == id).FirstOrDefault();

        public Weapon Create(Weapon weapon)
        {
            _weapons.InsertOne(weapon);
            return weapon;
        }

        public void Remove(Weapon weaponToRemove) =>
            _weapons.DeleteOne(weapon => weapon.Id == weaponToRemove.Id);

        public void Remove(string id) =>
            _weapons.DeleteOne(weapon => weapon.Id == id);

    }
}
