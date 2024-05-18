using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5_Or2
{
    class Calisan 
    {
        public int eskiMaas, zamorani;
        int yeniMaas;

        public void yenimaasHesaplama() 
        {
            yeniMaas = eskiMaas + (eskiMaas * zamorani / 100);
            Console.WriteLine("yeni maaş {0} olarak hesaplandı", yeniMaas);
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan memur = new Calisan();
            Console.WriteLine("eski maaşı girin:");
            memur.eskiMaas = Int32.Parse(Console.ReadLine());

            Console.Write("zam oranı : ");
            memur.zamorani = Int32.Parse(Console.ReadLine());

            memur.yenimaasHesaplama();
            Console.Read();

            //metod konusu bitti

        }
    }
}
