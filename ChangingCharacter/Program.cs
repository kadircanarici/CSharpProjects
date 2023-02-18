using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 1)
            {
                char first = words[i][0];
                char last = words[i][words[i].Length - 1];
                words[i] = last + words[i].Substring(1, words[i].Length - 2) + first;
            }
        }

        string output = String.Join(" ", words);
        Console.WriteLine("Output: " + output);
        Console.ReadKey();
    }
}
