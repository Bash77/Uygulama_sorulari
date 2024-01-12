using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiSayiArasiFaktoriyel
{
    internal class Program
    {
        public static int faktoriyelHesapla(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * faktoriyelHesapla(n - 1);
            }

        }

        public static void AralikFaktoriyel(int x, int y)
        {
            // x ve y'nin kontrolü
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            // x ve y arasındaki sayıların bulunması
            for (int i = x+1; i< y; i++)
            {
                Console.WriteLine(i + "'n faktoriyeli " + faktoriyelHesapla(i));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("X sayini giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Y sayini giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
           
            AralikFaktoriyel(x, y);


            Console.ReadKey();

        }
    }
}
