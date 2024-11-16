using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EF_İnheritance.Entites
{
    // İnstance'ını oluşturmak istemioyrum.Sadece miras verebilsin
    public abstract class BasePerson
    {
        public int Id { get; set; } // her sınıfa bir Id vermek zorunlu ve ototamık olarak sql tanımlar ben atama yapamam
        public string Name { get; set; }
        public DateTime BirtDate { get; set; }
    }
}
