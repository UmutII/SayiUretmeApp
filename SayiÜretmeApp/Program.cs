using System;
using System.Linq;

namespace SayıÜretmeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üretilmesini İstediğiniz Sayı Adetini Giriniz:");
            byte adet = byte.Parse(Console.ReadLine());
            Console.Clear();

            int[] sayilar = new int[adet];
            Random rastgele = new Random();
            int i = 0;
            while (i < adet)
            {
                int sayi = rastgele.Next();
                if (sayilar.Contains(sayi))
                    continue;
                sayilar[i] = sayi; i++;

            }
            Array.Sort(sayilar);

            foreach (int sayi in sayilar)

                Console.WriteLine(sayi);

            Console.ReadKey();


        }
    }
}
