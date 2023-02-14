using System;

class Program
{
    static void Main()
    {
        Console.Write("Üçgenin boyutu: ");
        int size = int.Parse(Console.ReadLine());

        var triangle = new Triangle(size);
        triangle.Draw();
    }
}

class Triangle
{
    private readonly int _size;

    public Triangle(int size)
    {
        _size = size;
    }

    public void Draw()
    {
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < 2 * _size - 1; j++)
            {
                if (j >= _size - i - 1 && j <= _size + i - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
