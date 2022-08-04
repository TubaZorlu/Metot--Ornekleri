using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaş_Hesabı
{
    class Program
    {
        static void Main(string[] args)
        {
            YasHesabi();
            Console.ReadLine();
        }

        private static void YasHesabi() 
        {
            Console.WriteLine("Lütfen doğum yılınızı giriniz ");

            int yas = int.Parse(Console.ReadLine());
            int hesap = 2022 - yas;
            Console.WriteLine($"Yaşınız: {hesap}");
            
        }
    }
}
