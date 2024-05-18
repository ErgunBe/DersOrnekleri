using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2donemor2
{
    internal class Program
    {
        class vatandas
        {
            public string adi, saoyadi, tcNo;
        }

        class calisan : vatandas 
        {
            public string sicilNo;
        }

        class memur : calisan
        {
            public string atanmayili;
        }

        class isci : calisan 
        {
            public string sendika;
        }

        class ogrenci : vatandas 
        {
            public string ogrenciNo;
        }
        static void Main(string[] args)
        {
            vatandas kisi1 = new vatandas();
            kisi1.adi = "Ergün"; //kendi
            kisi1.saoyadi = "Besli";//kendi
            kisi1.tcNo = "12345678901";//kendi

            calisan kisi2 = new calisan();
            kisi2.adi = "mehmet";  // kalıtım
            kisi2.saoyadi = "korkmaz";//kalıtım
            kisi2.tcNo = "12345678901";//kalıtım
            kisi2.sicilNo = "4588455";//kendi

            memur kisi3 = new memur();
            kisi3.adi = "hasan";
            kisi3.saoyadi = "kaya";
            kisi3.tcNo = "12345678901";
            kisi3.sicilNo = "564845645645";
            kisi3.atanmayili = "2022";

            isci kisi4 = new isci();
            kisi4.adi = "fatma";
            kisi4.saoyadi = "tartan";
            kisi4.tcNo = "12345678901";
            kisi4.sicilNo = "84578545";
            kisi4.sendika = "türk sendikası";

            ogrenci kisi5 = new ogrenci();
            kisi5.adi = "merve";
            kisi5.saoyadi = "olcay";
            kisi5.tcNo = "12345678901";
            kisi5.ogrenciNo = "22740023";

            Console.ReadLine();
        }
    }
}
