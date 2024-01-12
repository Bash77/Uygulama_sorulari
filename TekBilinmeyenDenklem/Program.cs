using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekBilinmeyenDenklem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tekrar:
            Console.WriteLine("A degeri giriniz: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("B degeri giriniz: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if(a != 0)
            {
                double x = -b / a;
                Console.WriteLine("x degeri: " + x);
            }
            else
            {
                Console.WriteLine("Denklemde 'A' sıfır olamaz.");
            }
            goto tekrar;
                Console.WriteLine("Geçersiz bir sayı girişi yaptınız.");
           



            Console.ReadLine();
        }
    }
}
