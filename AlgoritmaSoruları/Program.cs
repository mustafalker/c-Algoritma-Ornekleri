using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmaSoruları
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Tersinden okunduğunda aynı olan asal sayıları bulma
            //Console.WriteLine("1. Sayı : ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayı : ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int sayi = sayi1; sayi < sayi2; sayi++)
            //{
            //    int check = 0;
            //    int yeniSayi = 0;

            //    for (int i = 2; i < sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            check++;
            //            break;
            //        }
            //    }
            //    if (check == 1)
            //    {
            //        //Console.WriteLine($"{sayi} asal değildir."); Buralara istersek sayıların durumunuda yazdırabiliriz . 
            //    }
            //    else
            //    {

            //        //Console.WriteLine($"{sayi} asaldır .");

            //        yeniSayi = sayi;

            //        string str = yeniSayi.ToString();
            //        char[] charArray = str.ToCharArray();
            //        Array.Reverse(charArray);

            //        string sayıTerse = new string(charArray);
            //        int reverseNumber = int.Parse(sayıTerse);



            //        if (reverseNumber == yeniSayi)
            //        {
            //            Console.WriteLine(reverseNumber);
            //        }
            //        //else
            //        //{
            //        //    Console.WriteLine($"{yeniSayi} Sayısının Tersi Kendisine Eşit Değildir ! "); 
            //        //}
            //    }

            //} 
            #endregion

            #region latin kare matrisi oluşturma

            Console.WriteLine("Döndürmek İstediğiniz Sayıyı Girin : ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string numberString = sayi.ToString();

            int[] dizi = new int[numberString.Length];

            for (int i = 0; i < numberString.Length; i++)
            {
                dizi[i] = int.Parse(numberString[i].ToString());
            }
            Console.WriteLine(numberString);



            List<int> list = dizi.ToList();
            for (int i = 0; i < dizi.Length; i++)
            {
                int kafadaki = dizi[i];
                list.RemoveAt(0);
                list.Add(kafadaki);

                foreach (int j in list)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
            #endregion

        }
    }
}
