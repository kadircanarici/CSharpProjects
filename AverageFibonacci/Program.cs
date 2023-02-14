using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan derinlik değerini iste
        Console.Write("Fibonacci serisinin derinliği: ");
        int depth = int.Parse(Console.ReadLine());

        // Fibonacci sınıfından yeni bir nesne oluştur
        var fib = new Fibonacci();
        // Girilen derinliğe göre Fibonacci serisinin ortalamasını hesapla
        var mean = fib.Average(depth);

        // Sonucu yazdır
        Console.WriteLine("Ortalama: " + mean);
    }
}

class Fibonacci
{
    // Girilen derinliğe göre Fibonacci serisinin ortalamasını hesaplayan metot
    public double Average(int depth)
    {
        // Derinlik 1'den küçükse 0 döndür
        if (depth < 1) return 0;

        double sum = 0;
        int a = 0;
        int b = 1;

        // Fibonacci serisindeki sayıları hesapla ve topla
        for (int i = 1; i <= depth; i++)
        {
            int temp = b;
            b = a + b;
            a = temp;
            sum += a;
        }

        // Toplamı derinliğe bölerek ortalama hesapla
        return sum / depth;
    }
}
