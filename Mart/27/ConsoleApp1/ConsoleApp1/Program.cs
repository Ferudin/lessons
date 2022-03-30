using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
         static void Main(string[] args)
        {

            Console.WriteLine("Adınız nedir?");
            string ad = Console.ReadLine();

            Console.WriteLine("Soyadınız nedir?");
            string soyad = Console.ReadLine();

            Console.WriteLine("neçe yaşınız var?");
            string yas = Console.ReadLine();

            Console.WriteLine("hansı iş sayesinde işdiyirsiniz");
            string ish = Console.ReadLine();

            Console.WriteLine("Hansı ölkede yaşıyırsız?");
            string olke = Console.ReadLine();

            Console.WriteLine("Hansı şeherde yaşıyırsız?");
            string seher = Console.ReadLine();

            Console.WriteLine("hobbileriniz nedir?");
            string hobbiler = Console.ReadLine();

            Console.WriteLine("avtomobil süre bilirsiniz?");
            string avtomobil = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);

            Console.WriteLine("yaş: " + yas);

            Console.WriteLine("iş: " + ish);

            Console.WriteLine("Olke: " + olke);

            Console.WriteLine("şeher: " + seher);

            Console.WriteLine("hobbiler: " + hobbiler);

            Console.WriteLine("avtomobil: " + avtomobil);




            Console.ReadLine();
        }
    }
}
