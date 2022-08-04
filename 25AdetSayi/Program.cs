using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25AdetSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            YirmiBesAdetSayi();
            Console.ReadLine();

        }

        private static void YirmiBesAdetSayi() 
        {
            int sayi;
            int adet = 0;
            int negatifAdet = 0;
            int negatifToplam = 0;
            int ciftAdet = 0;
            int carpım = 1;
            int yediAdet = 0;
            bool sayiMi;

            Console.WriteLine("HOŞGELDİNİZ\n*********************");
            Console.WriteLine("25 adet sayı girmeniz gerekmetedir.\nLütten sayı girişlerini yapınız");
            do
            {
                Console.Write($"{adet + 1}.Sayı : ");
                sayiMi = int.TryParse(Console.ReadLine(), out sayi);

                while (!sayiMi)
                {
                    Console.WriteLine("Hatalı giriş yaptınız . Lütfen geçerli bir sayi giriniz");
                    sayiMi = int.TryParse(Console.ReadLine(), out sayi);
                }

                if (sayi < 0)
                {
                    negatifToplam = negatifToplam + sayi;
                    negatifAdet++;
                    adet++;
                }
                if (sayi % 2 == 0)
                {
                    carpım = carpım * sayi;
                    ciftAdet++;
                    adet++;
                }
                if (sayi == 7)
                {
                    yediAdet++;
                    adet++;
                }

            } while (adet<=24);      

            Console.WriteLine($"Negatif Adet  : {negatifAdet}\n" + $"Negatif Toplam : {negatifToplam}");
            Console.WriteLine($"Çift Adet  : {ciftAdet}\n" + $"Çift Çarpım : {carpım}");
            Console.WriteLine($"Girilen yedi adedi:  {yediAdet}");
       
        }
    }
}
