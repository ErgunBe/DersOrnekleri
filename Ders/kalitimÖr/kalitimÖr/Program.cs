using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimÖr
{
    class canli
    {
        public int yasamSuresi;
    }

    class hayvan: canli 
    {
        public int ayaksayisi, gozsayisi;
    }

    class bitki: canli 
    {
        public bool meyveVeriyormu;//burada bool true veya false dönüyor
    }

    class kedi: hayvan 
    {
        public string gozRengi;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            hayvan kopek = new hayvan();
            kopek.ayaksayisi = 4;
            kopek.gozsayisi = 2;
            kopek.yasamSuresi = 20;

            bitki kavak = new bitki();
            kavak.meyveVeriyormu = false;//kendi özelligi
            kavak.yasamSuresi = 60;//kalıtım özelligi

            canli insan = new canli();
            insan.yasamSuresi = 80;  // kendi özelligi

            kedi vanKedisi = new kedi();
            vanKedisi.ayaksayisi = 4;
            vanKedisi.gozsayisi=2;
            vanKedisi.yasamSuresi=25;
            vanKedisi.gozRengi = "mavi-yeşil";

            Console.WriteLine("ayak sayısı: {0}",vanKedisi.ayaksayisi);
            Console.WriteLine("goz sayisi: {0}", vanKedisi.gozsayisi);
            Console.WriteLine("yaşam süresi: {0}", vanKedisi.yasamSuresi);
            Console.WriteLine("göz rengi: {0}", vanKedisi.gozRengi);

            Console.ReadLine();

        }
    }
}
