using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenesysItemCollection.Models
{
    public class Weapon
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [Display(Name = "ID")]
        public string Id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Skill")]
        public string skill { get; set; }
        [Display(Name = "Damage")]
        public int damage { get; set; }
        [Display(Name = "Critical")]
        public int critical { get; set; }
        [Display(Name = "Range")]
        public string range { get; set; }
        [Display(Name = "Encumberance")]
        public int encumbrance { get; set; }
        [Display(Name = "Price")]
        public int price { get; set; }
        [Display(Name = "Rarity")]
        public int rarity { get; set; }
        [Display(Name = "Hard Points")]
        public int hardpoints { get; set; }
        public List<string> special { get; set; }
        [Display(Name = "Notes")]
        public string notes { get; set; }
        
    }
}
