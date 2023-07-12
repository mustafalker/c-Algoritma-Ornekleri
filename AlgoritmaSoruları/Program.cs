using System;

namespace AlgoritmaSoruları
{
    internal class Program
    {
        # region Tersinden okunduğunda aynı şekilde okunan olan asal sayıları bulma 
        static void Main(string[] args)
        {
                
                Console.WriteLine("1. Sayı : ");
                int sayi1 = int.Parse(Console.ReadLine());

                Console.WriteLine("2. Sayı : ");
                int sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

            for (int sayi = sayi1; sayi < sayi2; sayi++)
            {
                int check = 0;
                int yeniSayi = 0;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        check++;
                        break;
                    }
                }
                if (check == 1)
                {
                    //Console.WriteLine($"{sayi} asal değildir."); Buralara istersek sayıların durumunuda yazdırabiliriz . 
                }
                else
                {
                    
                    //Console.WriteLine($"{sayi} asaldır .");

                    yeniSayi = sayi;

                    string str = yeniSayi.ToString();
                    char[] charArray = str.ToCharArray();
                    Array.Reverse(charArray);

                    string sayıTerse = new string(charArray);
                    int reverseNumber = int.Parse(sayıTerse);

                    

                    if (reverseNumber == yeniSayi)
                    {
                        Console.WriteLine(reverseNumber);
                    }
                    //else
                    //{
                    //    Console.WriteLine($"{yeniSayi} Sayısının Tersi Kendisine Eşit Değildir ! "); 
                    //}
                }
                
            }
        }
        #endregion
    }
}
