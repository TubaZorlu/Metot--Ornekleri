using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İşlem_Yaptıra_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Acılıs();
            IsleSecme();
            Hesaplama();
            Tekrar();
            Console.ReadLine();
        }

        private static void Acılıs() 
        {
            Console.WriteLine("PROGRAMA HOŞGELDİNİZ\n********************");
        }
        private static void IsleSecme()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz\n(Toplama:T / Çıkarma : F / Çarpma : C /Bölme : B )");
        }     
        public static void Hesaplama()         
        {
            string secim;
            string msg = "Lütfen belirtilen işlemlerden birini seçiniz";

            secim = Console.ReadLine().ToUpper();

            if (secim != "T" && secim != "F" && secim != "C" && secim != "B")
            {
                Console.WriteLine(msg);
                secim = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Lütfen Sayi1 i giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Sayi2 yi giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case "T":
                    int toplam = sayi1 + sayi2;
                    msg = $"Toplama Sonucuu : {toplam}";
                    break;
                case "F":
                    int fark = sayi1 - sayi2;
                    msg = $"Çıkarma Sonucuu : {fark}";
                    break;
                case "C":
                    int carpma = sayi1 * sayi2;
                    msg = $"Çarpma Sonucuu : {carpma}";
                    break;
                case "B":

                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Bolme işlemi için sayi2'ye sıfırdan farklı bir değer verilmelidir");
                        break;
                    }
                    double bolme = (double)sayi1 / sayi2;
                    msg = $"Bölme Sonucuu : {bolme}";
                    break;
            }

            Console.WriteLine(msg);

        }
        private static void Tekrar( ) 
        
        {
            string tekrar;
            Console.WriteLine("Tekrar Yapmak istermisiniz(  Evet ,  Hayır )");
             tekrar =Console.ReadLine().ToUpper();

            if (tekrar =="E")
            {
                Hesaplama();
            }

            else if (tekrar == "H")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("yanlış bir seçim yaptınız tekrar giriniz");
                tekrar = Console.ReadLine().ToUpper();
            }

            
        }

          
    }
}
