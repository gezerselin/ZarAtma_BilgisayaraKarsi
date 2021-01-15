using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6_2_ZarAtma
{
    class Zar
    {
        // her zarın 6 yüzü vardır

        public int Deger { get; set; }

        // her zar atılır  // her zar rastgele bir deger üretir

        public void At()
        {
            Random random = new Random();
           
            
            Deger = random.Next(1, 7);
                

        }
    }
}
