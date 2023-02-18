using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kaç tane sayı gireceksiniz? ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] sayilar = new int[n];
        int kucukFarklarToplami = 0, buyukMutlakKarelerToplami = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write((i + 1) + ". sayıyı giriniz: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());

            if (sayilar[i] < 67)
            {
                if (i > 0)
                {
                    kucukFarklarToplami += Math.Abs(sayilar[i] - sayilar[i - 1]);
                }
            }
            else
            {
                buyukMutlakKarelerToplami += (sayilar[i] - 67) * (sayilar[i] - 67);
            }
        }

        Console.WriteLine("Küçük sayıların farklarının toplamı: " + kucukFarklarToplami);
        Console.WriteLine("Büyük sayıların farklarının mutlak karelerinin toplamı: " + buyukMutlakKarelerToplami);
    }
}
