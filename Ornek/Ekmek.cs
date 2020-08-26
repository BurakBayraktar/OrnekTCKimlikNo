using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    public class Ekmek:Urun
    {
        public Ekmek(string urunAdi, double fiyat, int gramaj, string unTuru)
        {
            UrunAdi = urunAdi;
            Fiyat = fiyat;
            Gramaj = gramaj;
            UnTuru = unTuru;
        }
        public int Gramaj { get; set; }
        public string UnTuru { get; set; }
    }
}
