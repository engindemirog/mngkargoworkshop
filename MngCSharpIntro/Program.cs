using System;

namespace MngCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //DegiskenDiziDongu();
            double dolarDun = 7.91;
            double dolarbugun = 7.91;

            if (dolarbugun<dolarDun || dolarbugun > dolarDun)
            {
                Console.WriteLine("Dolar değişim ikonu");
            }
            else
            {
                Console.WriteLine("Dolar eşittir ikonu");
            }

            //Bu kodu ternary operatör ile yazınız

            //Defensive programming
            

        }

        private static void DegiskenDiziDongu()
        {
            //byte,short,int,long
            int vade = 36;

            string haberBaslik = "HABERİNİZ OLSUN";

            //float,decimal,double
            double faiz = 1.59;
            double geriOdeme = 69580.08;



            //Oracle, Sql Server, MySql, PostgreSql,Access -->>RDBMS
            //MongoDB,FireBase -->>NoSQL
            string[] krediler = new string[7];
            krediler[0] = "Hızlı Kredi"; //SET
            krediler[1] = "Maaşını Halkbanktan Alanlar";
            krediler[2] = "Hızlı Kredi 2";
            krediler[3] = "Hızlı Kredi 3";
            krediler[4] = "Hızlı Kredi 4";
            krediler[5] = "Hızlı Kredi 5";
            krediler[6] = "Hızlı Kredi 6";

            int i;
            for (i = 0; i < krediler.Length; i++)
            {
                krediler[0] = "ssrfsdfsadf";
                Console.WriteLine(krediler[i]);
            }

            Console.WriteLine(i);

            foreach (var kredi in krediler)
            {
                Console.WriteLine(kredi);

            }

            int sayac = 0; ;
            while (sayac < krediler.Length)
            {
                Console.WriteLine(krediler[sayac]);
                sayac++;
            }

            Console.WriteLine(sayac);

            var durum = i == sayac;
        }
    }
}
