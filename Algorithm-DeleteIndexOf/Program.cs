using System;

class Program
{
    static void Main()
    {
        Console.Write("String ve index değerini giriniz (örn: algoritma,3): ");
        string input = Console.ReadLine();

        // Kullanıcının girdiği değeri ',' karakterine göre ayırarak string ve integer değerlerini alıyoruz
        string[] inputArr = input.Split(',');
        string str = inputArr[0];
        int index = int.Parse(inputArr[1]);

        // İlgili indexteki karakteri çıkartarak ekrana yazdırıyoruz
        if (index < str.Length)
            Console.WriteLine(str.Remove(index, 1));
        else
            Console.WriteLine("Hatalı index değeri.");
    }
}
