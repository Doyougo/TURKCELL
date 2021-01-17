using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaBahisli 
{
    public class BahisciEkle : Form
    {
        public Bahisci bahisci = new Bahisci();
        public BahisciEkle()
       {

       }   
        public BahisciEkle(string ad)
        {
            bahisci.Ad = ad;
           
        }
    

        
        
    }
}
