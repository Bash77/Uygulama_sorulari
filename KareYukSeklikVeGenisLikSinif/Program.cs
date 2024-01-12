using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareYukSeklikVeGenisLikSinif
{
    internal class Program
    {
        class Kare
        {
            private int _yukseklik;
            private int _genislik;

            public Kare(int yukseklik, int genislik)
            {
                if(yukseklik <  0)
                {
                    throw new ArgumentException("Yükseklik sıfırdan büyük olmalıdır.");
                }
                if (genislik < 0)
                {
                    throw new ArgumentException("Genişlik sıfırdan büyük olmalıdır.");
                }

                _yukseklik = yukseklik;
                _genislik = genislik;
            }
            public int Alani()
            {
                return _yukseklik * _genislik;
            }
        }
        static void Main(string[] args)
        {
            // Yükseklik ve genişlik değerlerinin alınması
            Console.WriteLine("Karenin yüksekliğini giriniz:");
            int yukseklik = int.Parse(Console.ReadLine());
            Console.WriteLine("Karenin genişliğini giriniz:");
            int genislik = int.Parse(Console.ReadLine());

            // Kare nesnesi oluşturulması
            Kare kare = new Kare(yukseklik, genislik);

            // Alanın hesaplanması ve yazdırılması
            int alan = kare.Alani();
            Console.WriteLine("Karenin alanı: " +  alan);


            Console.ReadLine();
        }
    }
}
