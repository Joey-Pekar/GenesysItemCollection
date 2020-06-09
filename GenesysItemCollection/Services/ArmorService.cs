using GenesysItemCollection.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenesysItemCollection.Services
{
    public class ArmorService
    {

        private readonly IMongoCollection<Armor> _armor;

        public ArmorService(IDatabaseSettings settings)
        {

            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _armor = database.GetCollection<Armor>(settings.ArmorCollectionName);

        }

        public List<Armor> Get() => _armor.Find(weapon => true).ToList();

        public Armor Get(string id) => _armor.Find<Armor>(armor => armor.Id == id).FirstOrDefault();

        public Armor Create(Armor armor)
        {
            _armor.InsertOne(armor);
            return armor;
        }

        public void Remove(Armor armorToRemove) =>
            _armor.DeleteOne(armor => armor.Id == armorToRemove.Id);

        public void Remove(string id) =>
            _armor.DeleteOne(armor => armor.Id == id);

    }

}

