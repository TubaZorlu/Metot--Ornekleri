using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ad_Soyad
{
    class Program
    {
        static void Main(string[] args)
        {

            AdSoyad();
            Console.ReadLine();
        }

        private static void AdSoyad() 
        {

            Console.WriteLine("Lütfen Adınızı Giriniz: ");
            string ad = Console.ReadLine();


            Console.WriteLine("Lütfen Soyadınızı Giriniz: ");
            string soyad = Console.ReadLine();

            Console.WriteLine($"{ad} {soyad} sisteme hoşgeldiniz!!!");

        }
            
          
    }
}
