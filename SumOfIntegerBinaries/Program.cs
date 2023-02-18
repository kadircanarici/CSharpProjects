using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Lütfen sayıları girin:");
        string inputStr = Console.ReadLine();
        string[] inputArr = inputStr.Split(' ');
        List<int> numbers = new List<int>();

        for (int i = 0; i < inputArr.Length; i++)
        {
            numbers.Add(int.Parse(inputArr[i]));
        }

        Dictionary<int, int> sums = new Dictionary<int, int>();
        List<int> result = new List<int>();

        for (int i = 0; i < numbers.Count; i += 2)
        {
            int total = numbers[i] + numbers[i + 1];

            if (!sums.ContainsKey(total))
            {
                sums[total] = 1;
                result.Add(total);
            }
            else
            {
                result.Add((int)Math.Pow(total, 2));
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
