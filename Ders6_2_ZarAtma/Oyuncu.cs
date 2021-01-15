using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6_2_ZarAtma
{
    class Oyuncu
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Zar OyuncununZari { get; set; }

        public int Bakiye { get; set; }

        public void Oyna()
        {
            OyuncununZari.At();
        }
        
    

        public Oyuncu()
        {
            this.Ad = Ad;
            this.Bakiye = Bakiye;
         
        }
        public Oyuncu(string ad, int bakiye)
        {
            Ad = ad;
            Bakiye = bakiye;
        }
    }
}
