using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string tipi metnleri saxlamaq ucun istifade olunur
            //string ad = "Orxan";

            ////int tipi tam reqemleri saxlamaq ucun istifade olunur
            //int yas = 27;

            ////kesr ededleri asagidaki tiplerde deyisenlerde saxlamaq olur
            //decimal ondaliqReqem = 25.2m;
            //float ondaliqReqem2 = 40.1f;
            //double ondaliqReqem3 = 30.2;

            ////Bool tipi True ve False deyerlerini saxlayir. True dogru, False yanlis demekdir.
            //bool havaSoyuqdur = false;
            //bool havaIstidir = true;

            //Console.WriteLine(ad);
            //Console.WriteLine(yas);
            //Console.WriteLine(ondaliqReqem);
            //Console.WriteLine(ondaliqReqem2);
            //Console.WriteLine(ondaliqReqem3);

            /*
             "salam"
             "menim adim Firudindir"
             40
             50.2
             true
             false
             50.6
             */
            
            string deyisen = "salam";
            string deyise = "menim adım Firudindi";
            int sayi = 40;
            double qiymet = 50.6;
            bool odenisOlundu = false;
            bool masinAlindi = false;


            //Console.WriteLine(deyisen);
            //Console.WriteLine(deyise);
            //Console.WriteLine(sayi);
            //Console.WriteLine(qiymet);
            //Console.WriteLine(odenisOlundu);
            //Console.WriteLine(masinAlindi);

            if (odenisOlundu)
            {
                //true olanda bura girir
                Console.WriteLine("Pul odenılıb");
            }
            else
            {
                //false olanda bura girir
                Console.WriteLine("Pul odenılmeyıb.");
            }


            int a = 10;
            int b = 20;

            bool netice = a > b;

            if (netice)
            {
                Console.WriteLine("a deyiseninin deyeri, b deyiseninin deyerinden boyukdur");
            }
            else
            {
                Console.WriteLine("b deyiseninin deyeri, a deyiseninin deyerinden boyukdur");
            }


            int c = 30;
            int d = 45;

            bool sonuc = c > d;

            if (sonuc)
            {
                Console.WriteLine("c sonucunun deyeri d sonucunun deyerinden boyukdur ");
            }
            else
            {
                Console.WriteLine("d sonucunun deyeri c sonucunun deyerinden boyukdur ");
            }




            string avto = "Mercedes";
            string basqaAvto = "Bmw";

            if(avto == basqaAvto) //iki beraberdir isaresi muqayise operatorudur ve deyerlerinin eyni olub-olmamasini yoxlayib true ve ya false netice qaytarir
            {
                Console.WriteLine("Avtomobiller eynidir");
            }
            

               










            Console.ReadLine();
        }
    }
}
