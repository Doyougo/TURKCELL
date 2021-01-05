using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Uygulamasi
{  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu kilogram cinsinden giriniz:");
            float kilo = float.Parse(Console.ReadLine());
            Console.WriteLine("Boyunuzu santimetre cinsinden giriniz:");
            float boy = float.Parse(Console.ReadLine());
            boy = boy / 100;
            float BMI = kilo / (boy * boy);
            Console.WriteLine($"BMI= {BMI}");
            if (BMI <= 18.4)
            {
                Console.WriteLine(" İdeal kilonuzun altındasınız :(");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine(" Kilonuz tamamen normal \\_0_/ ");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("İdeal kilonuzun üstündesiniz :(");
            }
            else if (BMI >= 30 && BMI <= 34.9)
            {
                Console.WriteLine("Şişman (Obez) - 1. Sınıf :'(");
            }
            else if (BMI >= 35 && BMI <= 35.9)
            {
                Console.WriteLine("Şişman (Obez) - 2. Sınıf :'( ");
            }
            else
            {
                Console.WriteLine("Şişman (Obez) - 3. Sınıf :'( ");
            }
            Console.ReadLine();
        }
    }
}
