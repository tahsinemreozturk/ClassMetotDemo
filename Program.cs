using ClassMetotDemo;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri musteri1= new Musteri();
        musteri1.MusteriAdi = "Emre";
        musteri1.MusteriSoyadi = "Ozturk";
        musteri1.MusteriId = "22";
        musteri1.MusteriNumarasi = "A23D";

        Musteri musteri2 = new Musteri();
        musteri2.MusteriAdi = "Tahsin";
        musteri2.MusteriSoyadi = "Ozturk";
        musteri2.MusteriId = "23";
        musteri2.MusteriNumarasi = "A23D33";

        Musteri[] musteriler = new Musteri[] { musteri1,musteri2 };

        foreach (Musteri musteri in musteriler)
        {
            Console.WriteLine("Musteri Eklendi: " + musteri.MusteriId);
            Console.WriteLine("Musteri Adi: " + musteri.MusteriAdi);
            Console.WriteLine("Musteri Soyadi: " + musteri.MusteriSoyadi);
            Console.WriteLine("Musteri Numarasi: " + musteri.MusteriNumarasi);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");

        }
        Console.WriteLine("/n Methot version");

        MusteriManagment musteriManagment= new MusteriManagment();

        musteriManagment.Ekleme(musteri1);
        musteriManagment.Ekleme(musteri2);
        Console.WriteLine( "____________" );

        Console.WriteLine("List");
        musteriManagment.Listeleme(musteri1);   
        musteriManagment.Listeleme(musteri2);
        Console.WriteLine("____________");

        Console.WriteLine("Silme");
        musteriManagment.Silme(musteri1);
        musteriManagment.Silme(musteri2);

        Console.ReadLine();


    }
}