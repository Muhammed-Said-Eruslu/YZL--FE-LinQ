using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EF_RelationShip.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        // Navigation Property
        public int CatogeryRefId { get; set; }
        public Catogery Catogery { get; set; } // her bır urunun bir categorisi vardır

       public ProductDetail Detail { get; set; } // her bir Product'ın bir tane detayı vardır
    }
}
