using System;

class Program
{
    static void Main()
    {
        Console.Write("Üçgenin boyutu: "); // Kullanıcıya üçgenin boyutunu girmesi istenir.
        int size = int.Parse(Console.ReadLine()); // Kullanıcının girdiği boyut bilgisi okunur ve bir tamsayıya dönüştürülür.

        var triangle = new Triangle(size); // Üçgen nesnesi oluşturulur ve boyut bilgisi ile birlikte yaratılır.
        triangle.Draw(); // Üçgen çizdirilir.
    }
}

class Triangle
{
    private readonly int _size; // Üçgenin boyutu, yalnızca kurucu metod aracılığıyla atanabilen bir özellik olarak tanımlanır.

    public Triangle(int size) // Kurucu metod, üçgen boyutunu alır ve özellik değerini ayarlar.
    {
        _size = size;
    }

    public void Draw() // Üçgeni çizmek için kullanılan metot.
    {
        for (int i = 0; i < _size; i++) // Satırların oluşturulması için döngü başlatılır.
        {
            for (int j = 0; j < 2 * _size - 1; j++) // Her bir satırın karakterlerinin oluşturulması için iç içe döngü başlatılır.
            {
                if (j >= _size - i - 1 && j <= _size + i - 1) // Eğer karakter üçgenin içindeyse, yıldız yazdırılır.
                    Console.Write("*");
                else // Eğer karakter üçgenin dışındaysa, boşluk yazdırılır.
                    Console.Write(" ");
            }
            Console.WriteLine(); // Her satırın sonunda bir alt satıra geçmek için bir satır sonu karakteri yazdırılır.
        }
    }
}
