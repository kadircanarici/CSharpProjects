using System;

class Program
{
    static void Main()
    {
        Console.Write("Dairenin yarıçapı: ");
        double radius = double.Parse(Console.ReadLine());

        // Circle sınıfından bir nesne oluşturulur ve çizme işlemi için Draw metodu çağrılır
        var circle = new Circle(radius);
        circle.Draw();
    }
}

class Circle
{
    // Yarıçap bilgisini tutacak private readonly bir değişken tanımlanır
    private readonly double _radius;

    // Yapıcı metot, yarıçap değerini alır ve _radius değişkenine atar
    public Circle(double radius)
    {
        _radius = radius;
    }

    // Daire çizimini gerçekleştiren metot
    public void Draw()
    {
        // Döngüler kullanarak her bir karakterin konumu hesaplanır ve konsola yazdırılır
        for (int y = (int)Math.Ceiling(-_radius); y <= (int)Math.Floor(_radius); y++)
        {
            for (int x = (int)Math.Ceiling(-_radius); x <= (int)Math.Floor(_radius); x++)
            {
                // Eğer koordinatlar dairenin içindeyse "*" karakteri yazdırılır, aksi halde " " karakteri yazdırılır
                if (x * x + y * y <= _radius * _radius)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            // Her bir satır sonunda bir alt satıra geçilir
            Console.WriteLine();
        }
    }
}
