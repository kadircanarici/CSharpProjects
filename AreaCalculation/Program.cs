using AreaCalculation.Geometrik;

class Program
{
    static void Main()
    {
        Console.Write("Hangi şekli seçmek istersiniz? (Kare, Daire, Üçgen, Dikdörtgen): ");
        string secilenSekil = Console.ReadLine();

        switch (secilenSekil.ToLower())
        {
            case "kare":
                Console.Write("Kenar uzunluğu giriniz: ");
                double kareKenarUzunlugu = Convert.ToDouble(Console.ReadLine());
                Kare kare = new Kare(kareKenarUzunlugu);
                Console.WriteLine($"Kare Alanı: {kare.AlanHesapla()}, Kare Çevresi: {kare.CevreHesapla()}");
                break;
            case "daire":
                Console.Write("Yarıçapı giriniz: ");
                double daireYariCap = double.Parse(Console.ReadLine());
                Daire daire = new Daire(daireYariCap);
                Console.Write("Hangi boyutu hesaplamak istersiniz? (Alan, Çevre): ");
                string daireBoyutu = Console.ReadLine();
                if (daireBoyutu.ToLower() == "alan")
                {
                    Console.WriteLine($"Daire alanı: {daire.AlanHesapla()}");
                }
                else if (daireBoyutu.ToLower() == "çevre")
                {
                    Console.WriteLine($"Daire çevresi: {daire.CevreHesapla()}");
                }
                else
                {
                    Console.WriteLine("Geçersiz boyut seçimi!");
                }
                break;
            case "üçgen":
                Console.Write("Üçgenin taban kenar uzunluğunu girin: ");
                double tabanKenarUzunlugu = double.Parse(Console.ReadLine());

                Console.Write("Üçgenin yüksekliğini girin: ");
                double yükseklik = double.Parse(Console.ReadLine());

                Console.Write("Üçgenin ilk kenar uzunluğunu girin: ");
                double ilkKenarUzunlugu = double.Parse(Console.ReadLine());

                Console.Write("Üçgenin ikinci kenar uzunluğunu girin: ");
                double ikinciKenarUzunlugu = double.Parse(Console.ReadLine());

                Console.Write("Üçgenin üçüncü kenar uzunluğunu girin: ");
                double ücüncüKenarUzunlugu = double.Parse(Console.ReadLine());

                Ucgen ucgen = new Ucgen(tabanKenarUzunlugu, yükseklik, ilkKenarUzunlugu, ikinciKenarUzunlugu, ücüncüKenarUzunlugu);
                Console.WriteLine($"Üçgen Alanı: {ucgen.AlanHesapla()}, Üçgen Çevresi: {ucgen.CevreHesapla()}");
                break;

            case "dikdörtgen":
                Console.Write("Dikdörtgenin kısa kenar uzunluğunu girin: ");
                double dikdortgenKisaKenar = Convert.ToDouble(Console.ReadLine());
                Console.Write("Dikdörtgenin uzun kenar uzunluğunu girin: ");
                double dikdortgenUzunKenar = Convert.ToDouble(Console.ReadLine());

                Dikdortgen dikdortgen = new Dikdortgen(dikdortgenKisaKenar, dikdortgenUzunKenar);
                Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.AlanHesapla()}, Dikdörtgen Çevresi: {dikdortgen.CevreHesapla()}, Dikdörtgen Köşegeni: {dikdortgen.KosegenHesapla()}");
                break;
            default:
                Console.WriteLine("Geçersiz şekil seçimi!");
                break;
        }
    }
}