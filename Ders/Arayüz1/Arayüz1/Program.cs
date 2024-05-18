using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayüz1
{
    interface Ialan
    {
        void alanHesapla();
    }

    interface Icevre
    {
        void cevreHesapla();
    }

    public class kare : Ialan, Icevre
    {
        public int alan, cevre, kenar;
        public void alanHesapla()
        {
            alan = kenar * kenar;
            Console.WriteLine(alan);
        }

        public void cevreHesapla()
        {
            cevre = 4 * kenar;
            Console.WriteLine(cevre);

        }

    }

    public class daire : Ialan, Icevre
    {
        public double alan, cevre, yarıcap;
        public void alanHesapla()
        {
            alan = 3.14 * yarıcap * yarıcap;
            Console.WriteLine(alan);

        }

        public void cevreHesapla()
        {
            cevre = 2 * 3.14 * yarıcap;
            Console.WriteLine(cevre);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            kare kare = new kare();
            kare.kenar = 10;
            kare.alanHesapla();
            kare.cevreHesapla();

            Console.WriteLine("-----------------------");

            daire daire = new daire();
            daire.yarıcap = 10;
            daire.alanHesapla();
            daire.cevreHesapla();

            Console.WriteLine("-----------------------");

            Ialan sekil1 = kare;
            sekil1.alanHesapla();
            Ialan sekil2 = daire;
            sekil2.alanHesapla();

            Console.WriteLine("-----------------------");

            Icevre sekil3 = kare;
            sekil3.cevreHesapla();
            Icevre sekil4 = daire;
            sekil4.cevreHesapla();

            Console.WriteLine("-----------------------");



            Console.ReadLine();
        }
    }
}
