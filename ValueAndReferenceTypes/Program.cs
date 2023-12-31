﻿namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            // Önce num1 ve num2 değişkenlerine değer tanımladık. num1'in değerini num2'nin 30 olan değerine eşitledik.
            // Num'İn değerini num2'nin 30 olan değerine eşitledikten sonra num2'nin değerini 65 yaptığımız için, num1 in değeri hala 30'dur.
            Console.WriteLine(num1); // 30

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };

            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]); // 999

            // Sayısal değer tipleri int,decimal,float,double,bool(0 ve 1) = değer tipleridir.
            // Array, Class, Interface = referans tiplerdir. 
            // Sonuçların farklı gelmesinin sebebi, değer ramde stackte, referans tipler heapte tutulur.
        }
    }
}