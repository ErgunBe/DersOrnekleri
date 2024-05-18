using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tuple patterns
            //int s1 = 10;
            //int s2 = 20;

            //string mesaj = "";
            //switch (s1, s2)
            //{
            //    case (5, 10):
            //        mesaj = "5 ile 10 değerleri";
            //        break;
            //    case (10, 20):
            //        mesaj = "10 ile 20 değerleri";
            //        break;


            //}


            //string mesaj = (s1, s2) switch
            //{
            //    (5, 10) => "5 ile 10 değerleri",
            //    (10, 20) => "10 ile 20 değerleri"
            //};
            //Console.WriteLine(mesaj);
            #endregion

            #region if

            //Console.Write("lütfen isminizi giriniz: ");
            // string a = Console.ReadLine();

            // if (a == "merhaba")
            // {
            //     Console.WriteLine("Hoşgeldiniz");
            // }

            // else { Console.WriteLine("yanlış giriş"); }

            //Console.WriteLine("2 sayıyı giriniz: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //if (a > b) 
            //{
            //    Console.WriteLine("{0} daha büyük",a);
            //}
            //else if (b > a) 
            //{
            //    Console.WriteLine("{0} daha büyük",b);
            //}

            //else { Console.WriteLine("iki sayıda eşit");
            //}

            //Console.WriteLine("lütfen bir sayı giriniz");
            //int a = Convert.ToInt32(Console.ReadLine());

            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("{0} çiftir",a);
            //}

            //else
            //{
            //    Console.WriteLine("{0} tektir",a);
            //}

            Console.WriteLine("kullanıcı Adı giriniz: ");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("şifre giriniz: ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "1234") 
            {
                Console.WriteLine("girişiniz başarılı");
            }

            else { Console.WriteLine("giriş başarısız"); }
            #endregion
        }
    }
}
