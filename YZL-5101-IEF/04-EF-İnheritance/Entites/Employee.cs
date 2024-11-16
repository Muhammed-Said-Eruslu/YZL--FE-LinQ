using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EF_İnheritance.Entites
{
    public partial class Employee:BasePerson
    {
        public DateTime AdmissionDate { get; set; }
        public string JobDescription { get; set; }
    }
}
