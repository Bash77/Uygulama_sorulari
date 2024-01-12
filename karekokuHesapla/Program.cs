using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karekokuHesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz: ");
            string girilenSayi = Console.ReadLine();

            if(double.TryParse(girilenSayi, out double sayi))
            {
                if(sayi >= 0)
                {
                     
                 double karekok = Math.Sqrt(sayi);
                    Console.WriteLine("Girilen sayinin karekoku: " + karekok);

                }
                else
                {
                    Console.WriteLine("Negatif sayıların karekökü bulunamaz.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girişi yaptınız.");
            }
            Console.ReadKey();
        }
        
    }
}
