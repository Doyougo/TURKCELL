using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilar
    {
        class Program
        {
            static void Main(string[] args)
            {
                bool asalMi = true;
            int cnt = 0;
                Console.WriteLine("2");
                for (int i = 3; i <= 10000; i ++)
                 {
                    asalMi = true;

                    for (int bolen = 2; bolen < i; bolen++)
                    {
                        if (i % bolen == 0)
                        {
                            asalMi = false;
                            break;
                        }

                    }
                    if (asalMi)
                    {
                        Console.WriteLine(i);
                     }
                
                }
            Console.ReadLine();
        }
        }
    }


