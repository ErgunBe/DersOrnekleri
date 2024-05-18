using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim2
{
    class vatandas
    {
        public string adi, soyadi, tcno;
    }
    class calisan: vatandas
    {
        public string sicilNo;
    }
    class memur: calisan 
    {
        public string atanamaYili;
    }
    class isci: calisan 
    {
        public string sendika;
    }
    class ogrenci: vatandas
    {
        public string ögrenciNo;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            vatandas kisi1 = new vatandas();
            kisi1.adi = "sefa";
            kisi1.soyadi = "sagar";
            kisi1.tcno = "12345678901";

            calisan kisi2 = new calisan();
            kisi2.adi = "ergün";
            kisi2.soyadi = "besli";
            kisi2.tcno = "12345678901";
            kisi2.sicilNo = "147852369";

            memur kisi3 = new memur();
            kisi3.adi = "serkan";
            kisi3.soyadi = "uymaz";
            kisi3.tcno = "12345678901";
            kisi3.sicilNo = "147852369";
            kisi3.atanamaYili = "2021";

            isci kisi4 = new isci();
            kisi4.adi = "sercan";
            kisi4.soyadi = "yıldırım";
            kisi4.tcno = "12345678901";
            kisi4.sicilNo = "147852369";
            kisi4.sendika = "türk sendika";

            ogrenci kisi5 = new ogrenci();
            kisi5.adi = "ahmet";
            kisi5.soyadi = "bilgic";
            kisi5.ögrenciNo = "22740028";
            
            Console.ReadLine();
        }
    }
}
