using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyelSayilar
{
    internal class Program
    {
        public static int faktoriyel(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * faktoriyel(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("N degeri giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= n / 2; i += 2)
            {
                Console.WriteLine( i + "'in faktöriyeli  "+   faktoriyel(i));
            }

            Console.ReadLine();
        }
    }
}
