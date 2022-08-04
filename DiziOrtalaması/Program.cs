using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrtalaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 4, 5, 7 };

            Ortalama(dizi );
            Console.ReadLine();
            
        }

        private static void Ortalama(params int[] dizi)
        {
            int toplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = toplam + dizi[i];
            }

            double ort = (double)toplam / dizi.Length;
            Console.WriteLine($"Dizi ortalaması : {Math.Round(ort,2)}");

        }
    }


}
