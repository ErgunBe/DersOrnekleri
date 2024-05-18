using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersc_2donem
{
    internal class Program
    {
        class canli
        {
            public int yasamsuresi;
        }

        class hayvan : canli
        {
            public int ayaksayisi, gozsayisi;
        }

        class bitki : canli
        {
            public bool meyveVeriyorMu;
        }
        static void Main(string[] args)
        {
            hayvan kedi = new hayvan();
            kedi.ayaksayisi = 4; //kendi özelligi
            kedi.gozsayisi = 2; // kendi özlegi
            kedi.yasamsuresi = 20;//kalıtım özeligi

            bitki kavak = new bitki();
            kavak.meyveVeriyorMu = false;
            kavak.yasamsuresi = 60;

            canli insan = new canli();
            insan.yasamsuresi = 80;

            Console.ReadLine(ca);

        }
    }
}
