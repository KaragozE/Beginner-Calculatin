using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. vize notu:");
            int not1 = Convert.ToInt32(Console.ReadLine().ToString());
            Console.Write("final notu:");
            int final = Convert.ToInt32(Console.ReadLine().ToString());

            double ortalama = ortalamaHesap(not1,final);

            if (not1 < 0 && not1 > 100) 
            {
                Console.WriteLine("gecerli not giriniz");
            }
            else
            {
                
                if (final < 0 && final > 100) 
                {
                    Console.WriteLine("gecerli not giriniz");
                }
                else
                {
                    Console.WriteLine("ortalamaniz:" + ortalama);
                }
                  
            }

           
            Console.ReadKey ();


        }

        public static double ortalamaHesap(int not1, int final)
        {

            double ortalama = ((not1 * 3.0 / 10) + (final * 7.0 / 10));
            return ortalama;
        }
    }

}
