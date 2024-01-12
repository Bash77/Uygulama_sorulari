using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConstructVSDeconstruct.Program;

namespace ConstructVSDeconstruct
{
 
    internal class Program
    {
        public abstract class Sekil
        {
            public abstract double Alan();
        }

        public abstract class sekil
        {
            public abstract double Alan();
        }

        public class Ucgen : Sekil
        {
            public double Taban { get; set; }
            public double Yukseklik { get; set; }

            public Ucgen(double taban, double yukseklik)
            {
                Taban = taban;
                Yukseklik = yukseklik;
            }

            public override double Alan()
            {
                return (Taban * Yukseklik) / 2;
            }
        }

        public class Daire : Sekil
        {
            public double Yarcap { get; set; }

            public Daire(double yarcap)
            {
                Yarcap = yarcap;
            }

            public override double Alan()
            {
                return Math.PI * Yarcap * Yarcap;
            }
        }

        static void Main(string[] args)
        {
            // Üçgen nesnesi oluşturma
            Ucgen ucgen = new Ucgen(10, 5);

            // Üçgenin alanını hesaplama
            double ucgenAlani = ucgen.Alan();

            // Alanı yazdırma
            Console.WriteLine("Üçgenin alanı: {0}", ucgenAlani);

            // Daire nesnesi oluşturma
            Daire daire = new Daire(5);

            // Dairenin alanını hesaplama
            double daireAlani = daire.Alan();

            // Alanı yazdırma
            Console.WriteLine("Dairenin alanı: {0}", daireAlani);


            Console.ReadKey();
        }
    }
}
