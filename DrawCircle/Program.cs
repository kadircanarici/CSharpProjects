using System;

class Program
{
    static void Main()
    {
        Console.Write("Dairenin yarıçapı: ");
        double radius = double.Parse(Console.ReadLine());

        var circle = new Circle(radius);
        circle.Draw();
    }
}

class Circle
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public void Draw()
    {
        for (int y = (int)Math.Ceiling(-_radius); y <= (int)Math.Floor(_radius); y++)
        {
            for (int x = (int)Math.Ceiling(-_radius); x <= (int)Math.Floor(_radius); x++)
            {
                if (x * x + y * y <= _radius * _radius)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
