using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Max_Min_Ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 55,63,-9,196,78,65,75,86,935,753 };
            int min = sayilar[0]; //Min sayıyı dizinin ilk elemanına atadım çünkü dizinin elemanlarını kontrol ederken kolaylık sağlayacak
            int max = sayilar[0]; //Max sayıyı dizinin ilk elemanına atadım çünkü dizinin elemanlarını kontrol ederken kolaylık sağlayacak
            int sayilarinToplami = 0; 
            int sayilarinOrtalamasi = 0;
            for (int i=0; i != sayilar.Length-1 ; i++)
            {

                if(sayilar[i] < min)
                {
                    min = sayilar[i]; // min sayıyla dizinin her elemanını tek tek kontrol ederek min den daha bir küçük sayı varsa yeni min değeri olarak o sayi atanır.
                }
                if(max < sayilar[i])
                {
                    max = sayilar[i];  // max sayıyla dizinin her elemanını tek tek kontrol ederek min den daha bir büyük sayı varsa yeni min değeri olarak o sayi atanır.
                }
                sayilarinToplami = sayilarinToplami + sayilar[i]; // dizinin her elemanı toplama eklenir ve dizinin elemanları toplamı bulunur.
            }
            sayilarinOrtalamasi = sayilarinToplami  / sayilar.Length; // dizinin elemanlarının toplamının dizinin uzunluğuna bölünmesi bize ortalamayı verecektir.
            Console.WriteLine($"Max : {max}");
            Console.WriteLine($"Main : {min}");
            Console.WriteLine($"Ortalama : {sayilarinOrtalamasi}");
            Console.ReadLine();

        }
    }
}
