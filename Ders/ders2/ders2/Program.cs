
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2
{
    class daire
    {
        double r;
        public double yaricap
        {
            set
            {
                if (value <= 0)
                {
                    r = 1;
                }
                else
                {
                    r = value;
                }
            }
        }

        public double cevre
        {
            get
            {
                return 2 * 3.14 * r;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            daire daire1 = new daire();
            daire1.yaricap = 10;
            Console.WriteLine("dairenin çevresi: {0}", daire1.cevre);
            Console.ReadLine();

        }
    }
}
