using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlanıHesaplama
{
    class kare
    {
        public int kenarUzunlugu;
        int alan;
        //public dışardan erişebilmek
        public void alanHesapla() //böyle oldumu metot oluyor
        {
            alan = kenarUzunlugu * kenarUzunlugu;
            Console.WriteLine("karenin alanı {0} olarak hesaplandı", alan);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            kare sekil1 = new kare();
            Console.WriteLine("kenar uzunlugu girin:");
            sekil1.kenarUzunlugu = Int32.Parse(Console.ReadLine());//int32.parse demek string  bir ifadeyi inte cevirme
            sekil1.alanHesapla();
            Console.Read();
            Console.ReadLine();
        }
    }
}
