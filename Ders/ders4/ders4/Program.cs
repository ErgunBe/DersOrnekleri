using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders4
{
    class kare
    {
        public int kenar, alanı;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            kare kare1 = new kare();

            Console.Write("kenar uzunlugu: ");
            kare1.kenar = Int32.Parse(Console.ReadLine());
            kare1.alanı = kare1.kenar * kare1.kenar;

            Console.Write ("karenin alanı : ");
            Console.Write(kare1.alanı);
            Console.Read();

        }
    }
}
