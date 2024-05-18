using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yikiciDikdortgen
{
    class dikdortgen
    {
        public int kisa, uzun, alan;

        public dikdortgen()//nesne oluşturulurken çalışacak
        {
            kisa = 10;
            uzun = 20;
        }
        ~dikdortgen() //nesne hafızadan silinince çalışacak
        {
            Console.WriteLine("program bitti");
        }

        public void alanHesapla()
        {
            alan = kisa * uzun;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dikdortgen sekil1 = new dikdortgen();
            Console.WriteLine("kisa kenar: {0}",sekil1.kisa);
            Console.WriteLine("uzun kenar: {0}",sekil1.uzun);

            sekil1.alanHesapla();
            Console.WriteLine("alan: {0}", sekil1.alan);

            Console.ReadLine();
        }
    }
}
