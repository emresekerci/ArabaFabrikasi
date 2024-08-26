using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>();
        string cevap;

        do
        {
            Console.WriteLine("Araba üretmek istiyor musunuz? (e/h)");
            cevap = Console.ReadLine().ToLower();

            if (cevap == "e")
            {
                // Kullanıcıdan araba özelliklerini alalım
                Console.Write("Seri Numarası: ");
                string seriNumarasi = Console.ReadLine();

                Console.Write("Marka: ");
                string marka = Console.ReadLine();

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Console.Write("Renk: ");
                string renk = Console.ReadLine();

                int kapiSayisi;
            Geri:
                Console.Write("Kapı Sayısı: ");
                bool success = int.TryParse(Console.ReadLine(), out kapiSayisi);

                if (!success)
                {
                    Console.WriteLine("Geçerli bir sayı giriniz.");
                    goto Geri;
                }

                // Yeni bir araba oluştur
                Araba yeniAraba = new Araba(seriNumarasi, marka, model, renk, kapiSayisi);
                arabalar.Add(yeniAraba);

                Console.WriteLine("Araba üretildi!\n");
            }
            else if (cevap != "h")
            {
                Console.WriteLine("Geçersiz cevap, lütfen tekrar deneyin.");
            }
        }
        while (cevap != "h");

        // Listeyi yazdır
        Console.WriteLine("\nÜretilen arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
}
