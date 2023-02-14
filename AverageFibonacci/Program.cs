using System;

class Program
{
    static void Main()
    {
        Console.Write("Fibonacci serisinin derinliği: ");
        int depth = int.Parse(Console.ReadLine());

        var fib = new Fibonacci();
        var mean = fib.Average(depth);

        Console.WriteLine("Ortalama: " + mean);
    }
}

class Fibonacci
{
    public double Average(int depth)
    {
        if (depth < 1) return 0;

        double sum = 0;
        int a = 0;
        int b = 1;

        for (int i = 1; i <= depth; i++)
        {
            int temp = b;
            b = a + b;
            a = temp;
            sum += a;
        }

        return sum / depth;
    }
}
