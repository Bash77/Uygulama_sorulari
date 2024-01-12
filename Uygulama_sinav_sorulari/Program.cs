using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_sinav_sorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
                
             double   b = 1, x;
            for(int a = 1; a<= 10; a++)
            {
                x = -b / a;
                Console.WriteLine("x: " + x);
            }

            Console.ReadLine();
        }
    }
}
