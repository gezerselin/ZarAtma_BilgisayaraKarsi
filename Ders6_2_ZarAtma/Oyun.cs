using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6_2_ZarAtma
{
    class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }

        public Oyuncu İkinciOyuncu { get; set; }

        public int Bahistutari { get; set; }
        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();

        }
        public void IkinciOyuncuZarAt()
        {
            İkinciOyuncu.Oyna();
        }

        public Oyuncu Karsilastir()
        {
            if (BirinciOyuncu.OyuncununZari.Deger > İkinciOyuncu.OyuncununZari.Deger)
            {
                BirinciOyuncu.Bakiye += Bahistutari;
                İkinciOyuncu.Bakiye -= Bahistutari;
                return BirinciOyuncu;

            }
            else if (BirinciOyuncu.OyuncununZari.Deger < İkinciOyuncu.OyuncununZari.Deger)
            {
                BirinciOyuncu.Bakiye -= Bahistutari;
                İkinciOyuncu.Bakiye += Bahistutari;
                return İkinciOyuncu;

            }
            else
            {
                return null;
            }
        }


        public Oyuncu kazananBul()
        {

            if(BirinciOyuncu.Bakiye <Bahistutari)
            {
                return İkinciOyuncu;
            }
            else
            {
                return BirinciOyuncu;
            }

        }

            

            
    }
}
