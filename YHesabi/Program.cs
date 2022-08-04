using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            YHesabi();
            Console.ReadLine();
        }


        private static void YHesabi()
        {
            double A, B, C, Y, toplam = 0, ort;
            int adet = 0, sayac = 1, aradakiYAdeti = 0;
            Console.WriteLine("HOŞGELFNİZ \n*****************");

        degerGir:
       
            if (sayac <= 50)
            {
                bool Adogrumu = false;
                bool Bdogrumu = false;
                bool Cdogrumu = false;
                do
                {
                    Console.WriteLine("Lütfen Geçerli bir A değerini giriniz");
                    Adogrumu = double.TryParse(Console.ReadLine(), out A);
                } while (!Adogrumu);

                do
                {
                    Console.WriteLine("Lütfen Geçerli bir B değerini giriniz");
                    Bdogrumu = double.TryParse(Console.ReadLine(), out B);

                } while (!Bdogrumu);

                do
                {
                    Console.WriteLine("Lütfen Geçerli bir C değerini giriniz");
                    Cdogrumu = double.TryParse(Console.ReadLine(), out C);

                } while (!Cdogrumu);

                if (C == 0)
                {
                    Console.WriteLine("C değeri 0 değerini alamaz lütfen tekrar giriniz");
                    C = int.Parse(Console.ReadLine());
                }

                Y = (A + B) / C;

                if (Y > 0)
                {
                    toplam = toplam + Y;
                    adet++;
                }

                if (Y > 30 && Y < 50)
                {
                    aradakiYAdeti++;
                }

                sayac++;
                goto degerGir;

            }

            ort = toplam / adet;

            Console.WriteLine($"Pozitif Y'lerin ortalaması :  {Math.Round(ort,2)}");
            Console.WriteLine($"30'dan büyük 50'den küçük Y adeti:  {aradakiYAdeti}");
           
        }
    }
}
