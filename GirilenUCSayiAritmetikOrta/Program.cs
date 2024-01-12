using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenUCSayiAritmetikOrta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz: ");
            string girilenSayi1 = Console.ReadLine();

            Console.Write("İkinci sayıyı giriniz: ");
            string girilenSayi2 = Console.ReadLine();

            Console.Write("Üçüncü sayıyı giriniz: ");
            string girilenSayi3 = Console.ReadLine();

            if (double.TryParse(girilenSayi1, out double sayi1) &&
                double.TryParse(girilenSayi2, out double sayi2) &&
                double.TryParse(girilenSayi3, out double sayi3))
            {
                double aritmetikOrtalama = (sayi1 + sayi2 + sayi3) / 3;
                Console.WriteLine("Girilen üç sayının aritmetik ortalaması: " + aritmetikOrtalama);

            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girişi yaptınız.");
            }
            Console.ReadLine();
        }
    }
}
