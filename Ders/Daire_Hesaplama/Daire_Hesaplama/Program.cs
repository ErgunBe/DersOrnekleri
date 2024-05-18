using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire_Hesaplama
{
    internal class Program
    {
        class Daire
        {
            double r;
            public const double PI = 3.14;

            public double yaricap
            {
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Yarıçap 0'dan büyük olması gerektiği için 1 olarak ayarlandı.");
                        r = 1;
                    }
                    else r = value;
                }
            }

            public double cevre
            {
                get
                {
                    return 2 * PI * r;
                }
            }

            public double alan
            {
                get
                {
                    return PI * r * r;
                }
            }

        }

        class program
        {
            static void Main(string[] args)
            {

                Daire daire1 = new Daire();
                Console.Write("Dairenin yarıçapını giriniz : ");
                daire1.yaricap = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dairenin çevresi : {0}", daire1.cevre);
                Console.WriteLine("Dairenin alanı : {0}", daire1.alan);
                Console.Read();
            }
        }
    }
}
