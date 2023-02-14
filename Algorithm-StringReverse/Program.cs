using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input: ");
        string input = Console.ReadLine(); // Kullanıcıdan bir string ifade isteniyor
        string[] words = input.Split(' '); // String ifade boşluklara göre ayrılıp words dizisine atılıyor
        for (int i = 0; i < words.Length; i++)
        { // words dizisindeki her kelime için döngü başlatılıyor
            string word = words[i]; // Dizideki kelime bir değişkene atılıyor
            if (word.Length > 1)
            { // Kelimenin uzunluğu 1'den büyükse işlem yapılıyor (1 harfli kelimelerde baş harfi sona taşımak anlamsızdır)
                char first = word[0]; // Kelimenin ilk harfi bir değişkene atılıyor
                words[i] = word.Substring(1) + first; // Kelimenin ilk harfi kesilip sona ekleniyor ve yeni kelime dizideki yerine atanıyor
            }
        }
        string output = string.Join(" ", words); // Kelimeler boşluklarla birleştirilip yeni bir string oluşturuluyor
        Console.WriteLine("Output: " + output); // Yeni string ekrana yazdırılıyor
    }
}
