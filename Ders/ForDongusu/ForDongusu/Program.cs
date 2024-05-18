using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());

            int faktoriyel = 1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            Console.WriteLine("faktöriyel : " +  faktoriyel);

            Console.ReadLine();
        }
    }
}
