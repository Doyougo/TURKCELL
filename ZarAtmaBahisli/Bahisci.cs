using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaBahisli
{
    public class Bahisci 
    {
        public int Butce { get; set; }
        public string Ad { get; set; }
        public int Miktar { get; set; }
        public int Secim { get; set; }
        public Bahisci()
        {
            Butce = 100;
        }
        public Bahisci(string ad, int miktar=0,int secim= 0, int butce=100)
        {
            Ad = ad;
            Miktar = miktar;
            Secim = secim;
            Butce = butce;
        }
        
        
    }

}
