using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    public class Telefon : Urun
    {
        public Telefon(string ad, double fiyat, string marka)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Marka = marka;
        }

        public string Ozellikler { get; set; }
        public string Marka { get; set; }


        private string _tcKimlikNo;
        public string TcKimlikNo
        {
            get
            {
                if (Convert.ToInt32(_tcKimlikNo) % 2 == 0)
                {
                    return _tcKimlikNo;
                }
                else
                {
                    return "Girilen TC Kimlik No hatalıdır.";
                }
            }
            set { _tcKimlikNo = value; }
        }
    }
