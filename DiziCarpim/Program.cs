using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziCarpim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Get row and column counts from the user
            Console.WriteLine("Satir sayisini giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sutun sayisini giriniz: ");
            int sutun = Convert.ToInt32(Console.ReadLine());

            // Create the 2D array dynamically
            int[,] dizi = new int[satir, sutun];
          
            for(int  i = 0; i < satir;  i++)
            {
                for(int j = 0; j < sutun; j++)
                {
                    Console.WriteLine("elemanını giriniz:", i, j);
                    dizi[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Calculate the product of elements
            int carpim = 1;
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    carpim *= dizi[i, j];
                }
            }

            // Print the result
            Console.WriteLine("Dizideki elemanların çarpımı: " +  carpim);

            Console.ReadLine();
        }
    }
}
