using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while dongusu
            System.Console.WriteLine("**** While ****");

            //1 den baslayarak console dan girilen sayiya kadar (sayi dahil) ortalama hesaplayip console a yazdıran program.

            System.Console.Write("Lütfen bir sayi girin: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam+=sayac;
                sayac++; 
            }
            System.Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri yazdiralim.

            char character = 'a';

            while (character <= 'z')
            {
                 System.Console.Write(character + " ");
                 character++;
            }

            System.Console.WriteLine("**** Foreach ****");

            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                System.Console.WriteLine(araba);
            }






        }
    }
}
