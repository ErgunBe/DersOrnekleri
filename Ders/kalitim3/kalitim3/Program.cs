using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim3
{
    class Sekil
    {
        public double alan, cevre;
    }

    class Kare : Sekil
    {
        public int kenarUzunlugu;
    }

    class Ucgen : Sekil
    {
        public int taban, yukseklik;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare();
            Console.Write("Karenin kenar uzunlugu : ");
            kare1.kenarUzunlugu = Int32.Parse(Console.ReadLine());
            kare1.alan = kare1.kenarUzunlugu * kare1.kenarUzunlugu;
            kare1.cevre = kare1.kenarUzunlugu * 4;

            Console.WriteLine("Karenin alanı : {0}", kare1.alan);
            Console.WriteLine("Karenin cevresi : {0}", kare1.cevre);


            Ucgen ucgen1 = new Ucgen();
            Console.Write("Ucgenin taban uzunlugu : ");
            ucgen1.taban = Int32.Parse(Console.ReadLine());
            Console.Write("ucgenin yuksekligi : ");
            ucgen1.yukseklik = Int32.Parse(Console.ReadLine());
            ucgen1.alan = ucgen1.taban * ucgen1.yukseklik / 2;
            ucgen1.cevre = ucgen1.taban * 3;

            Console.WriteLine("Ucgenin alanı : {0}", ucgen1.alan);
            Console.WriteLine("Ucgenin cevresi : {0}", ucgen1.cevre);

            Console.ReadLine();
        }
    }
}
