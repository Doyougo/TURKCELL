using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMiYokMu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Eskişehir", "İstanbul", "Ankara", "İzmir", "Samsun" };
            Console.WriteLine("Bir şehir giriniz");
            bool flag = false;
            string girilenSehir = Console.ReadLine();
            int indexNumarasi = 0;
            foreach (string sehir in sehirler)
            {
                indexNumarasi = indexNumarasi + 1;
                if (girilenSehir == sehir)
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine($"{girilenSehir} Var Index numarası ={indexNumarasi}");
            }
            else
            {
                Console.WriteLine($"Yok");
            }
            Console.ReadLine();
        }
    }
}
