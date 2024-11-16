using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EF_RelationShip.Entity
{
    public class ProductDetail
    {
        public string Color { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        [Key] // bunun anlamı primary key yapar
        public int ProductRefId { get; set; }
        public Product Product { get; set; } // her bir product detailin bir product'ı vardır
    }
}
