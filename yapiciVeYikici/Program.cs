using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapiciVeYikici
{
    internal class Program
    {
        class Dikdortgen
        {

            private int _genislik;
            private int _yukseklik;

            static int _toplamOlusturulanDikdortgenSayisi;
            static int _toplamSilinenDikdortgenSayisi;

            public Dikdortgen(int genislik, int yukseklik)
            {
                _genislik = genislik;
                _yukseklik = yukseklik;

                _toplamOlusturulanDikdortgenSayisi++;
                Console.WriteLine("Dikdörtgen oluşturuldu");
            }

            ~Dikdortgen()
            {
                _toplamSilinenDikdortgenSayisi++;
                Console.WriteLine("Dikdörtgen hafızadan silindi");
            }

            public

        int Genislik
            {
                get { return _genislik; }
                set { _genislik = value; }
            }

            public

        int Yukseklik
            {
                get { return _yukseklik; }
                set { _yukseklik = value; }
            }
        }
        static void Main(string[] args)
        {
            // İlk dikdörtgen nesnesi oluşturulması
            Dikdortgen dikdortgen1 = new Dikdortgen(10, 20);

            // İkinci dikdörtgen nesnesi oluşturulması
            Dikdortgen dikdortgen2 = new Dikdortgen(30, 40);
            // Dikdörtgen1 nesnesi silinmesi
            dikdortgen1 = null;

            // Dikdörtgen2 nesnesi silinmesi
            dikdortgen2 = null;

            // Toplam oluşturulan ve silinen dikdörtgen sayısının yazdırılması
            Console.WriteLine("Toplam oluşturulan dikdörtgen sayısı: {0}", Dikdortgen._ );
            Console.WriteLine("Toplam silinen dikdörtgen sayısı: {0}", Dikdortgen. );
        }
    }
}
