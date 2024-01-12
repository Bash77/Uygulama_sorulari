using System;

class Program
{
    static void Main(string[] args)
    {
        // 2 boyutlu dizi tanımlama
        int[,] dizi = new int[2, 3];

        // Dizi elemanlarını kullanıcıdan alma
        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            for (int j = 0; j < dizi.GetLength(1); j++)
            {  
                Console.WriteLine("Dizi[{0},{1}] elemanını giriniz: " , i , j);
                dizi[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Dizi elemanlarının toplamını bulma
        int toplam = 0;
        for (int i = 0; i < dizi.GetLength(0); i++)
        {
            for (int j = 0; j < dizi.GetLength(1); j++)
            {
                toplam += dizi[i, j];
            }
        }

        // Dizi elemanlarının toplamını yazdırma
        Console.WriteLine("Dizi elemanlarının toplamı: {0}", toplam);

        Console.ReadKey();
    }
}
