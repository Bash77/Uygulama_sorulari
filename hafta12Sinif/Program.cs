using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta12Sinif
{
    internal class Program
    {
        public class Satranç
        {
            public string Tür { get; set; }
            public string Renk { get; set; }

            public Satranç(string tür, string renk)
            {
                Tür = tür;
                Renk = renk;
            }

            public override string ToString()
            {
                return Tür + " " + Renk;
            }
        }
        public class Piyon : Satranç
        {
            public int HareketSayısı { get; set; }

            public Piyon(string tür, string renk) : base(tür, renk)
            {
                HareketSayısı = 2;
            }
        }
        public class Kale : Satranç
        {
            public int HareketYönü { get; set; }

            public Kale(string tür, string renk) : base(tür, renk)
            {
                HareketYönü = 1;
            }
        }
        public class Fil : Satranç
        {
            public int HareketYönü { get; set; }

            public Fil(string tür, string renk) : base(tür, renk)
            {
                HareketYönü = 2;
            }
        }
        public class Vezir : Satranç
        {
            public int HareketYönü { get; set; }

            public Vezir(string tür, string renk) : base(tür, renk)
            {
                HareketYönü = 3;
            }
        }

        static void Main(string[] args)
        {
            // Piyon nesnesi oluşturma
            Piyon piyon = new Piyon("Piyon", "Siyah");

            // Kale nesnesi oluşturma
            Kale kale = new Kale("Kale", "Beyaz");

            // Fil nesnesi oluşturma
            Fil fil = new Fil("Fil", "Siyah");

            // Vezir nesnesi oluşturma
            Vezir vezir = new Vezir("Vezir", "Beyaz");

            // Nesnelerin bilgilerini yazdırma
            Console.WriteLine(piyon);
            Console.WriteLine(kale);
            Console.WriteLine(fil);
            Console.WriteLine(vezir);

            Console.ReadKey();
        }
    }
}
