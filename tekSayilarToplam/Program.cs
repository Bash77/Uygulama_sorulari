using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekSayilarToplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tekrar:
            Console.WriteLine("N degeri giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<= n; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine("tekSayilar: " + i);
                }
                else
                {
                   goto tekrar;
                     Console.WriteLine("hatali giris yaptiniz");
                }
            }
            Console.ReadLine();
        }
    }
}
