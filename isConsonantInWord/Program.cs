using System;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metni girin: ");
            string metin = Console.ReadLine();

            string sessizler = "bcdfghjklmnpqrstvwxyz";
            string[] kelimeler = metin.Split(' ');

            foreach (string kelime in kelimeler)
            {
                bool sonuc = false;

                for (int i = 0; i < kelime.Length - 1; i++)
                {
                    if (sessizler.Contains(kelime[i].ToString().ToLower()) && sessizler.Contains(kelime[i + 1].ToString().ToLower()))
                    {
                        sonuc = true;
                        break;
                    }
                }

                Console.Write(sonuc + " ");
            }

            Console.ReadKey();
        }
    }
}
