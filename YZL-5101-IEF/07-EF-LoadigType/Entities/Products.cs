using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_EF_LoadigType.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        // Navigation
        public int CatogeryId { get; set; } // bir urunun hangı katogori ıd de oldugunu gosterir :Örn Catogoryde elektronık varsa ve urun bılgısayarsa ıdsı elektronığin sahip oldugu ıd yı tasır
        // Foreign Key
        public virtual Catogery Catogery { get; set; } // her bir urunun bir kategorısı vardır
    }
}
