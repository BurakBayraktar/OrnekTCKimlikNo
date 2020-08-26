using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    public class Pantolon : Urun
    {
        public Pantolon(string ad, double fiyat, string beden, string kumasTuru)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Beden = beden;
            KumasTuru = kumasTuru;
        }

        public string KumasTuru { get; set; }
        public string Beden { get; set; }
    }
}
