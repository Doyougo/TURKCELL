using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiBulmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random rastgeleSayiUretici = new Random();
            int rastgeleSayi = rastgeleSayiUretici.Next(1, 10);
            Console.WriteLine("Tahmininizi giriniz.");
            //int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
            bool sayiBulunduMu = false;

      
            while(!sayiBulunduMu)
            {
                int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());

                if (tahminEdilenSayi < rastgeleSayi)
                {
                    Console.WriteLine("Tahmininizi arttırın");
                  
                }
                else if (tahminEdilenSayi > rastgeleSayi)
                {
                    Console.WriteLine("Tahmininizi azaltın");
                    
                }
                else
                {
                    Console.WriteLine($"Tebrikler Sayınız {rastgeleSayi}");
                    Console.WriteLine("Tekrar oynamak oynamak için 1'e basınız :)");
                    int oyunOynamaIstegi = Convert.ToInt32(Console.ReadLine());

                    if (oyunOynamaIstegi == 1)
                    {
                        sayiBulunduMu = false;
                        Console.WriteLine("Tahmininizi giriniz.");
                        rastgeleSayi = rastgeleSayiUretici.Next(1, 10);
                    }
                    else
                        sayiBulunduMu = true;

                }
                
            }
            Console.ReadLine();
        }
    }
}
