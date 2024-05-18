using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomobilÖrnegi
{
    internal class Program
    {
        public abstract class motorluArac
        {
            public int motorHacmi;
            public int modelYili;

            public abstract void calis();
            public abstract void dur();
        }
        public class otomobil : motorluArac
        {
            public bool otomatikvites;
            public bool otonomSurus;

            public override void calis() 
            {
                Console.WriteLine("otomobil çalıştı");
            }

            public override void dur() 
            {
                Console.WriteLine("otomobil durdu");
            }

        }

        public class traktor:motorluArac
        {
            public bool romork;
            public override void calis()
            {
                Console.WriteLine("traktör çalıştı");
            }

            public override void dur()
            {
                Console.WriteLine("traktör durdu");
            }
        }
        static void Main(string[] args)
        {
            otomobil bmw = new otomobil();
            bmw.modelYili = 2023;
            bmw.motorHacmi = 2000;
            bmw.otomatikvites = true;
            bmw.otonomSurus = false;
            bmw.calis();
            bmw.dur();

            traktor newHolland = new traktor();
            newHolland.modelYili = 2015;
            newHolland.motorHacmi = 5000;
            newHolland.romork = true;
            newHolland.calis();
            newHolland.dur();

            Console.ReadLine();
        }
    }
}
