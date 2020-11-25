using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 30;

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20 ,30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 100;
            Console.WriteLine(sayilar1[0]);


            int[] mukemmelSayilar = new int[1];
            mukemmelSayilar[0] = 100;

            mukemmelSayilar = new int[2];
            mukemmelSayilar[1] = 200;

            List<int> sayilar = new List<int>();
            sayilar.Add(2);
            sayilar.Add(30);

            Console.WriteLine(sayi1);
            

            Console.WriteLine("Hello World!");
        }
    }
}
