using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classkullanma
{
    class islem
    {
        int ilk, ikinci, toplam;
        public int ilksayi
        {
            set
            {
                if (value <= 0) ilk = 0;
                else ilk = value;
            }
        }
        public int ikincisayi
        {
            set 
            {
                if(value <= 0) ikinci = 0;
                else ikinci = value;
            }
        }
        public int sonuc
        {
            get
            {
                toplam = ilk + ikinci;
                return toplam;
            }
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            islem toplama = new islem();

            Console.Write("ilk sayıyı giriniz: ");
            toplama.ilksayi = Int32.Parse(Console.ReadLine());

            Console.Write("ikinci sayıyı giriniz: ");
            toplama.ikincisayi = Int32.Parse(Console.ReadLine());

            Console.Write("iki sayının toplamı=");
            Console.Write(toplama.sonuc);

            Console.ReadLine();
        }
    }
}
