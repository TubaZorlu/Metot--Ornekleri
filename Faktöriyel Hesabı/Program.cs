using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktöriyel_Hesabı
{
    class Program
    {
        static void Main(string[] args)
        {

            Faktoriyel();
            Console.ReadLine();
            
        }

        private static void Faktoriyel() 
        {
            bool sayiMİ;
            int sayi;
            do
            {
                
                Console.WriteLine("Lütfen bir sayı giriniz ");
                sayiMİ = int.TryParse(Console.ReadLine(), out sayi); 

            } while (!sayiMİ); 

            int carpım = 1;
            
            for (int i = 1; i <= sayi ; i++)
            {

                carpım = carpım * i;
            }

            Console.WriteLine($"Faktoriyel : {carpım}");

        }
    }
}
