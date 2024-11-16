using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EF_İnheritance.Entites
{
    public class Customer :BasePerson
    {
        public DateTime LastPurchaseDate { get; set; }
        public int TotalVisit { get; set; }
    }
}
