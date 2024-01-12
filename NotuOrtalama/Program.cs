using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotuOrtalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tekrar:
            Console.WriteLine("Vize sinav notu giriniz: ");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final sinav notu giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());
            if(vize < 0 || final < 0)
            {
                goto tekrar;
                  Console.WriteLine("Hatali giriz tekrar giriniz..");
            }

            int ortlama = (vize/4 + final/60);
            if(ortlama > 50)
            {
                Console.WriteLine("Gecti.....");
            }
            else
            {
                Console.WriteLine("Kaldi....");
            }

            Console.ReadKey();
        }
    }
}
