
using System;


class Program
{
    static void Main()
    {

        //1. adım 10 adet tam sayı içerecek bir dizi tanımlayalım.
        int[] sayilar = new int[10];

        // dizinin elemanlarını bir for döngüsü ile doldurup ekrana yazdıralım.

        Console.WriteLine("10 adet tam sayı giriniz:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Sayı {i + 1}:");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nGirilen sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);

        }
        // 3. adım bu diziye kullanıcıdan alınan yeni bir değer ekleyiniz(11. eleman olarak)
        Console.Write("\nYeni bir sayı giriniz (11. eleman):");
        int yeniSayi = int.Parse(Console.ReadLine());
        sayilar = sayilar.Append(yeniSayi).ToArray();
        Console.WriteLine("\nYeni dizi:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        //4 adım bu diziyi büyükten küçüğe sıralama ve ekrana yazdırma
        Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
        var sortedSayilar = sayilar.OrderByDescending(x => x).ToArray();
        foreach (int sayi in sortedSayilar)

        {
            Console.WriteLine(sayi);

        }
    }
            
        }