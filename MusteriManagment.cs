using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManagment
    {
        public void Ekleme(Musteri musteri)     
        {
            Console.WriteLine("Musteri Eklendi: " + musteri.MusteriId);
            Console.WriteLine("Musteri Adi: " + musteri.MusteriAdi);
            Console.WriteLine("Musteri Soyadi: " + musteri.MusteriSoyadi);
            Console.WriteLine("Musteri Numarasi: " + musteri.MusteriNumarasi);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("\nAdi:" + musteri.MusteriAdi + "\nSoyadi: " + musteri.MusteriSoyadi + "\nMusteriNo: " + musteri.MusteriNumarasi, " " + "Musteri Silindi!");
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("ID:" + musteri.MusteriId + "\nAdi:" + musteri.MusteriAdi + "\nSoyadi:" + musteri.MusteriNumarasi);
        }
    }
}
