using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenesysItemCollection.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string WeaponsCollectionName { get; set; }
        public string ArmorCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }

    public interface IDatabaseSettings
    {
        string WeaponsCollectionName { get; set; }
        string ArmorCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
