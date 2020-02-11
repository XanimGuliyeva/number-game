using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reqem
{
    class Program
    {
        static void Main(string[] args)
        {
            int texmin=0, saygac=0;
            Console.WriteLine("***Number Game***");

            Random myNum = new Random();
            int reqem = myNum.Next(0, 100);
            Console.WriteLine("1-100 arasi eded daxil edin");

            while (texmin != reqem) {
                saygac++;
                texmin = Convert.ToInt32(Console.ReadLine());
                if (texmin > reqem)
                {
                    Console.WriteLine("Zehmet olmazsa {0}dan kicik eded daxil edin", texmin);
                }
                else if (texmin < reqem) {
                    Console.WriteLine("Zehmet olmazsa {0}dan boyuk eded daxil edin", texmin);
                }
            }
            Console.WriteLine("Tebrikler siz {0} defeye duzgun ededi tapdiniz", saygac);
            Console.ReadKey();
        }
    }
}
