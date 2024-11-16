using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_EF_LoadigType.Entities
{
    public class Catogery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string url { get; set; }
        public virtual ICollection<Products> Products { get; set; } // bir kategorının bırden fazla urunu olabılır
        // ICollectıon Kullanılmasının sebebi: Esneklık sağlar ekleme sılme gıbı destedgı vardır INumareable dan mıras almıstır farklı koleksıyon tıplerı ıle kullanılbılır yenıden kullanbılırlıgı arttırır değişime açıktır List<T> spesifik tablolar ıcın kullanılır kodun degısme ıhtımalı varsa ICollectıon daha mantıklı olur koleysıyon turunu  ılerde değiştirmemize olanak sağlar
        // Soyutlama : Koleksıyonun türüne odaklanmaz onun yerine onun nasıl kullanıldıgına odaklanır

    }
}
