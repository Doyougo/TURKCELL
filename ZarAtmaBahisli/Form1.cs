using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaBahisli
{
    public partial class Form1 : Form
    {
        int count = 0;
        Bahisci bahisci1 = new Bahisci();
        Bahisci bahisci2 = new Bahisci();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *  Bu oyunda iki oyuncu vardır.
             *  Her oyuncunun bir zarı vardır.
             *  Oyuncular zar atar
             *  Zarlar karşılaştırılır.
             *  Büyük atan kazanır.
             *  
             *  Nesneler:
             *   - Oyun
             *   - Oyuncu
             *   - Zar
             *  
             */
        }

        Oyun zarOyunu = new Oyun();
        private void buttonAd1_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncu1Ad.Text;
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdi);
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu1Ad.Text = zarOyunu.BirinciOyuncu.Ad;
            buttonOyuncu1.Text = zarOyunu.BirinciOyuncu.Ad + " zar atacak";
        }

        private void buttonAd2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncu = new Oyuncu(textBoxOyuncu2Ad.Text);
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu2Ad.Text = zarOyunu.IkinciOyuncu.Ad;
            buttonOyuncu2.Text = zarOyunu.IkinciOyuncu.Ad + " zar atacak";
        }

        private void buttonOyuncu1_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
            buttonOyuncu2.Enabled = true;
        }
        
        private void buttonOyuncu2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncuZarAt();
            labelOyuncu2Zar.Text = zarOyunu.IkinciOyuncu.OyuncununZari.Deger.ToString();
            Oyuncu kazanan = zarOyunu.Karsilastir();
            if (bahisci1.Secim != bahisci2.Secim)
            {
                if (kazanan == zarOyunu.BirinciOyuncu && bahisci1.Secim == 1)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = $"{bahisci1.Ad} paraları kaptı. ";
                    bahisci1.Butce = bahisci1.Butce + bahisci2.Miktar;
                    bahisci2.Butce = bahisci2.Butce - bahisci2.Miktar;
                    labelButce1.Text = $"{bahisci1.Butce}";
                    labelButce2.Text= $"{bahisci2.Butce}";
                }
                else if (kazanan == zarOyunu.BirinciOyuncu && bahisci2.Secim == 1)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = $"{bahisci2.Ad} paraları kaptı. ";
                    bahisci1.Butce = bahisci1.Butce - bahisci1.Miktar;
                    bahisci2.Butce = bahisci2.Butce + bahisci1.Miktar;
                    labelButce1.Text = $"{bahisci1.Butce}";
                    labelButce2.Text = $"{bahisci2.Butce}";
                }
                if (kazanan == zarOyunu.IkinciOyuncu && bahisci1.Secim == 2)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = $"{bahisci1.Ad} paraları kaptı. ";
                    bahisci1.Butce = bahisci1.Butce + bahisci2.Miktar;
                    bahisci2.Butce = bahisci2.Butce - bahisci2.Miktar;
                    labelButce1.Text = $"{bahisci1.Butce}";
                    labelButce2.Text = $"{bahisci2.Butce}";
                }
                else if (kazanan == zarOyunu.IkinciOyuncu && bahisci2.Secim == 2)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = $"{bahisci2.Ad} paraları kaptı. ";
                    bahisci1.Butce = bahisci1.Butce - bahisci1.Miktar;
                    bahisci2.Butce = bahisci2.Butce + bahisci1.Miktar;
                    labelButce1.Text = $"{bahisci1.Butce}";
                    labelButce2.Text = $"{bahisci2.Butce}";
                }
                if(zarOyunu.BirinciOyuncu == zarOyunu.IkinciOyuncu)
                {
                    labelKazanan.Text = "Beraberliiiik :)))";
                    labelKazanBahisci.Text = "Herkesin parası cebinde kalır:(";
                    labelButce1.Text = $"{bahisci1.Butce}";
                    labelButce2.Text = $"{bahisci2.Butce}";
                }
            }
            else if(bahisci1.Secim == bahisci2.Secim)
            {
                if (kazanan == zarOyunu.BirinciOyuncu && bahisci1.Secim == 1)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = "Herkesin parası cebinde kalır";
                }
                else if(kazanan == zarOyunu.IkinciOyuncu && bahisci1.Secim == 2)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = "Herkesin parası cebinde kalır";
                }
                else if(zarOyunu.BirinciOyuncu == zarOyunu.IkinciOyuncu && bahisci2.Secim==3)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = "Herkesin parası cebinde kalır";
                }
                else if(kazanan == zarOyunu.BirinciOyuncu && bahisci1.Secim != 1)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = "Kaybettiniz";
                    bahisci1.Butce = bahisci1.Butce - bahisci1.Miktar;
                    bahisci2.Butce = bahisci2.Butce - bahisci2.Miktar;
                    labelButce1.Text = $"{bahisci1.Butce}";
                    labelButce2.Text = $"{bahisci2.Butce}";
                }
                else if (kazanan == zarOyunu.IkinciOyuncu && bahisci1.Secim != 2)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = "Kaybettiniz";
                    bahisci1.Butce = bahisci1.Butce - bahisci1.Miktar;
                    bahisci2.Butce = bahisci2.Butce - bahisci2.Miktar;
                    labelButce1.Text = $"{bahisci1.Butce}";
                    labelButce2.Text = $"{bahisci2.Butce}";
                }
                else if (zarOyunu.BirinciOyuncu == zarOyunu.IkinciOyuncu && bahisci1.Secim != 3)
                {
                    labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı ";
                    labelKazanBahisci.Text = "Kaybettiniz";
                    bahisci1.Butce = bahisci1.Butce - bahisci1.Miktar;
                    bahisci2.Butce = bahisci2.Butce - bahisci2.Miktar;
                    labelButce1.Text = $"{bahisci1.Butce}";
                    labelButce2.Text = $"{bahisci2.Butce}";
                }
            }

        }
        
        private void buttonBahisciEkle_Click(object sender, EventArgs e)
        {
            count++;
            if(count == 1)
            {
                
                bahisci1.Ad = textBoxBahisciAd.Text;
                labelBirinciBahisci.Text = bahisci1.Ad;
            }
            if (count > 1)
            {
                
                bahisci2.Ad = textBoxBahisciAd.Text;
                labelIkinciBahisci.Text = bahisci2.Ad;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void buttonBirinciBahisciMiktar_Click(object sender, EventArgs e)
        {
            bahisci1.Miktar =Convert.ToInt32(textBoxBirinciBahisciMiktar.Text) ;
            if(bahisci1.Butce < bahisci1.Miktar)
            {
                labelKazanBahisci.Text = "Butceniz yetersiz";
            }
            
        }

        private void buttonIkinciBahisciMiktar_Click(object sender, EventArgs e)
        {
            bahisci2.Miktar = Convert.ToInt32(textBoxIkinciBahisciMiktar.Text);
            if (bahisci2.Butce < bahisci2.Miktar)
            {
                labelKazanBahisci.Text = "Butceniz yetersiz";
            }
        }
        
        private void ButtonBirinciOyuncuyuSec_Click(object sender, EventArgs e)
        {
            if (bahisci1.Butce > 0 && bahisci2.Butce > 0)
            {
                bahisci1.Secim = 1;
            }
            else
                labelKazanBahisci.Text = "Butceniz yetersiz";
        }

        private void buttonIkinciOyuncuyuSec_Click(object sender, EventArgs e)
        {
            if (bahisci1.Butce > 0 && bahisci2.Butce > 0)
                bahisci1.Secim = 2;
            else
                labelKazanBahisci.Text = "Butceniz yetersiz";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (bahisci1.Butce > 0 && bahisci2.Butce > 0)
                bahisci1.Secim = 3;
            else
                labelKazanBahisci.Text = "Butceniz yetersiz";
        }

        private void ButtonBirinciOyuncuyuSec2_Click(object sender, EventArgs e)
        {
            if (bahisci1.Butce > 0 && bahisci2.Butce > 0)
                bahisci2.Secim = 1;
            else
                labelKazanBahisci.Text = "Butceniz yetersiz";
        }

        private void buttonIkinciOyuncuyuSec2_Click(object sender, EventArgs e)
        {
            if (bahisci1.Butce > 0 && bahisci2.Butce > 0)
                bahisci2.Secim = 2;
            else
                labelKazanBahisci.Text = "Butceniz yetersiz";
        }

        private void buttonBerabere2_Click(object sender, EventArgs e)
        {
            if (bahisci1.Butce > 0 && bahisci2.Butce > 0)
                bahisci2.Secim = 3;
            else
                labelKazanBahisci.Text = "Butceniz yetersiz";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void labelKazanan_Click(object sender, EventArgs e)
        {

        }
    }
}