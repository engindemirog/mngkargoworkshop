using System;

namespace Workshop1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Sayı : ");
                var sayi = Convert.ToInt32(Console.ReadLine());
                bool durum = true;

                if (sayi == 2)
                {
                    Console.WriteLine("Asal");
                    return;
                }

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        durum = false;
                        break;
                    }
                }



                Console.WriteLine(durum == true ? "Asal" : "Asal Değil");
            }
            
        }
    }
}
