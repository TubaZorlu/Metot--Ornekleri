using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampüsOrtalama
{
{
    class Program
    {
        static void Main(string[] args)
        {
            Kampus();
            Console.ReadLine();
        }

        private static void Kampus() 
        {
            char cinsiyet;
            int kizOgrenciSayisi = 0, erkekOgrenciSayisi = 0, kizToplam = 0, erkekToplam = 0, ogrenciSayisi, kilo, kizOrt, erkekOrt;
            bool ogrenciDurumu;
            bool cinsiyetDurumu;
            bool kiloDogrumu;

            do
            {
                Console.WriteLine("Lütfen sınıftaki öğrenci sayısını giriniz");
                ogrenciDurumu = int.TryParse(Console.ReadLine(), out ogrenciSayisi);
                
                if (!ogrenciDurumu)               
                    Console.WriteLine("Hatalı giriş yaptınız");              
                
            } while (!ogrenciDurumu);

            if (ogrenciSayisi > 0)
            {
                for (int i = 0; i < ogrenciSayisi; i++)
                {
                    do
                    {
                        Console.Write("Lütfen öğrencinin cinsiyetini(E/K) giriniz :" + "   ");
                        cinsiyetDurumu = char.TryParse(Console.ReadLine().ToUpper(), out cinsiyet);

                        if (cinsiyet != 'E' && cinsiyet != 'K')                       
                            Console.WriteLine("Hatalı giriş yaptınız");                      

                    } while (cinsiyet != 'E' && cinsiyet != 'K');

                    do
                    {
                        Console.Write("Lütfen öğrencinin kilosunu giriniz" + "   ");
                        kiloDogrumu = int.TryParse(Console.ReadLine(), out kilo);

                        if (!kiloDogrumu)                      
                            Console.WriteLine("Hatalı kilo bilgisi girdiniz");                       

                    } while (!kiloDogrumu);

                    if (cinsiyet == 'K')
                    {
                        kizOgrenciSayisi++;                    
                        kizToplam = kizToplam + kilo;
                    }

                    else if (cinsiyet == 'E')
                    {
                        erkekOgrenciSayisi++;
                        erkekToplam = erkekToplam + kilo;
                    }
                }

            }
            if (kizOgrenciSayisi == 0)
            {
                erkekOrt = erkekToplam / erkekOgrenciSayisi;
                Console.WriteLine($"Erkek Ogrenci Sayısı : {erkekOgrenciSayisi} Kilo ortaması:  {erkekOrt}");
                Console.WriteLine("Sınıfta  kız öğrenci yoktur");
            }
            else if (erkekOgrenciSayisi == 0)
            {
                kizOrt = kizToplam / kizOgrenciSayisi;
                Console.WriteLine($"Kız Ogrenci Sayısı : {kizOgrenciSayisi}  Kilo ortalaması : {kizOrt} ");
                Console.WriteLine("Sınıfta erkek öğrenci yoktur");
            }

            else
            {
                kizOrt = kizToplam / kizOgrenciSayisi;
                erkekOrt = erkekToplam / erkekOgrenciSayisi;
                Console.WriteLine($"Erkek Ogrenci Sayısı : {erkekOgrenciSayisi} Kilo ortaması:  {erkekOrt}");
                Console.WriteLine($"Kız Ogrenci Sayısı : {kizOgrenciSayisi}  Kilo ortalaması : {kizOrt} ");
            }

        }
    }
}
