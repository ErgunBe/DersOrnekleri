using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapiciDikdortgen
{
    class dikdortgen
    {
        public int uzunKenar, kisaKenar;

        public dikdortgen()
        {
            uzunKenar = 20;
            kisaKenar = 10;
        }

        public dikdortgen(int kisa)
        {
            uzunKenar = 20;
            kisaKenar = kisa;
        }

        public dikdortgen(int kisa, int uzun)
        {
            uzunKenar = uzun;
            kisaKenar = kisa;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dikdortgen sekil1 = new dikdortgen();
            Console.WriteLine("kısa kenar; {0}, uzun kenar: {1}",sekil1.kisaKenar, sekil1.uzunKenar);

            dikdortgen sekil2 = new dikdortgen(2);
            Console.WriteLine("kisa kenar: {0}, uzun kenar:{1}",sekil2.kisaKenar, sekil2.uzunKenar);

            dikdortgen sekil3 = new dikdortgen(4,8);
            Console.WriteLine("kisa kenar: {0}, uzun kenar: {1}",sekil3.kisaKenar , sekil3.uzunKenar);

            dikdortgen sekil4 = new dikdortgen(5);
            Console.WriteLine("kisa kenar: {0}, uzun kenar: {1}",sekil4.kisaKenar,sekil4.uzunKenar);

            Console.ReadLine();
            
        }
    }
}
