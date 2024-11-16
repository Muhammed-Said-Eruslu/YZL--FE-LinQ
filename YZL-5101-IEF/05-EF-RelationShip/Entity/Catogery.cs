using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EF_RelationShip.Entity
{
    public class Catogery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Navigation Property
        public List<Product> Catogeries { get; set; } // her bır katagoredı bırden fazla urun olur
    }
}
