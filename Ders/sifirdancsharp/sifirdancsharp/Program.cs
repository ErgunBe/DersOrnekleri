using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifirdancsharp
{
    internal class Program
    {
        //Bir değişken class scope içerisinde tanımlanıyorsa buna global değişken diyoruz...
        int a;//glpbal değişken
        static void Main(string[] args)
        {
            //bool X = default(bool);
            //int Y = default(int);
            //string z = default(string);
            //const Double pi = 3.14; //const yazdıgımız zaman o değer sabit olur değiştirilemez 

            #region deep copy
            //deep copy(derin kopyalama) neticsindeki eldeki veri çoğalır/klonlanır (var olan veriyi kopyalama)
            //int a = 5;
            //int b = a;

            //a = a * 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Console.ReadLine();
            #endregion

            #region object //tüm türleri karşılayabilen bir turdur...

            #endregion

            #region boxing
            // object türdeki bir değişkene herhangi bir türdeki değeri göndermek boxing olarak nitelindirmektir

            #endregion

            #region unboxing
            //()cast operatörü parntezdir
            //cast operatörü , objeckt olan değişkenin solunda o objcektihangi türe unboxing etmek istiyorsak parantez içersine hedef türü bildirilerek kullanılır.
            //int _yas = (int)_yas; unboxing
            //Console.WriteLine(_yas * 5);
            #endregion

            #region var
            //string adi = "ergün";

            //var sayi = 87;
            // 1.var keyworlduyletanimlanan değişkenin değeri tanımlanma aşamasınd verilmelidir. verilmelidir ki türü belirleyip direkt ona dönüşebilsin o türde davranış sergileyebilsin

            // 2.var keyworldüyle tanımlanan değişkene ilk değer verildikten sonra o değerin türüne bürünecegi için sonraki durumlarda değeri farklı türlerde virlemez!!!

            // 3. var - object arasındaki fark ;
            // var4 bir keywordken object ise bir türdür. var atanan bir değerin türüne bürünürken , object atanan değeri boxing yaparak object de çevirir




            #endregion

            #region dynamic


            #endregion

            #region metinsel ifadeleri diger ifadelere dönüştürme
            #region parse metodu
            // parse metodu sadece string dataları hedef türe dönüştürülürken kullanılır
            //// örnek1
            //string x = "123";
            //short x2 = short.Parse(x);
            //Console.WriteLine(short.Parse(x) * 5); // string bir değeri short bir değere dönüştürdük 


            #endregion

            #region convert fonksiyonları
            #region örnek1
            //string x = "3,14";
            //double d = Convert.ToDouble(x);
            //Console.WriteLine(d);
            //Console.ReadLine();
            #endregion

            #endregion

            #endregion

            #region diger ifadelerin metinsel ifadelere dönüştürme
            #region convert fonksiyonu
            //int a = 25;
            //string a2 = Convert.ToString(a);
            #endregion

            #region Tostring fonksiyonu
            // tostring fonksiyonu tümmm ama tüm türlerde mevcutur.
            //float f = 35;
            //string f2 = f.ToString();

            #endregion
            #endregion

            #region sayısal ifadelerin kendi aralarında tür dönüşümü
            #region bilinciz tür dönüşümü
            //bir sayısal tür kendisinden daha geniş aralıktakibir başka sayısal türe atanması bilincsiz tür dönüşümüdür.
            #region örnek1
            //int a = 3000;
            //float f = a;
            #endregion
            #endregion

            #region bilincli tür dönüşümü
            //int x = 3000;
            //short y = (short)x;//()cast oparatörü
            #endregion
            #region checked
            //bilincli tür dönüşmü esnasında bir veri kayıbı söz konusu olursa eğer runtime'da bizleri uyaracak olan bir konturol mekanizmasıdır.
            //checked
            //{
            //    int a = 500;
            //    byte b = (byte)a;
            //    Console.WriteLine(y);
            //}

            #endregion
            #endregion

            #region bool türünün sayısal türe dönüştürülmesi
            //elimizdeki mantıksal bir değeri herhangi bir  sayısal degere convert edersek ilgili değerin mantıksal karşılıgını elde edebiliriz. 
            //bool b = true;
            //decimal i = Convert.ToDecimal(b);
            //Console.WriteLine(i);
            //Console.ReadLine();

            #endregion

            #region char türünü sayısal türe cevirme
            //char a = 'a';
            //int _a = (int)a;
            //Console.WriteLine(_a);
            //Console.ReadLine();
            #endregion

            //int a = 95;
            //char b = (char)a;
            //Console.WriteLine(a);
            //Console.ReadLine();

            #region swich case

            //swich case kodun akışında belirli bir şarta göre yönlendirme yapmamızı (farklı algoritma çalıştırmamızı / farklı operasyon gerçekleştirmemizi/ tetiklememizi sağlayan yapılanmadır.)
            //swich case yapılanması sadece bir değişkenin değerini sadece eşitlik durumlarında kontrol ederken kullanılabilir
            //sadece eşitlik durumu check edilecekse o zaman switch kullanılabilir

            //string adi = "Ahmet";

            //switch (adi)
            //{
            //    case "hilmi":
            //        Console.WriteLine("adı hilmi");
            //        break;

            //    case "Ayşe":
            //        Console.WriteLine("Adı Ayşe");
            //        break;

            //    case "mehmet":
            //        Console.WriteLine("Adı Mehmet");
            //        break;

            //    default:
            //        Console.WriteLine("hiçbiri değil");
            //        break;


            //}

            #endregion

            #region when
            //int satistutar = 1000;
            //switch (satistutar)
            //{
            //    case 1000 when (3 == 5):
            //        break;

            //    case 1000 when (3 == 3);
            //        break;
            //}



            #endregion

            #region goto

            //int i = 10;

            //switch (i)
            //{
            //    case 5:
            //        Console.WriteLine(i * 10);
            //        break;

            //    case 6:
            //        Console.WriteLine(i / 5);
            //        break;

            //    case 7:
            //        goto case 5;

            //    case 10:
            //        goto case 5;
            //}
            //Console.ReadLine();

            #endregion

            #region

            //string mesaj = "1";
            //switch (DateTime.Now.DayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        mesaj = "bu gün pazartesi";
            //        break;

            //    case DayOfWeek.Tuesday:
            //        mesaj = "bu gün salı";
            //        break;

            //    case DayOfWeek.Wednesday:
            //        mesaj = "bu gün çarşamba";
            //        break;

            //    case DayOfWeek.Thursday:
            //        mesaj = "bu gün perşmbe";
            //        break;

            //    case DayOfWeek.Friday:
            //        mesaj = "bu gün cuma";
            //        break;

            //    case DayOfWeek.Saturday:
            //        mesaj = "bu gün cumartesi";
            //        break;

            //    case DayOfWeek.Sunday:
            //        mesaj = "bu gün pazar";
            //        break;
            //}
            //Console.WriteLine(mesaj);
            //Console.ReadLine();

            //string mesaj = DateTime.Now.DayOfWeek switch
            //{
            //    DayOfWeek.Monday => "bu gün pazartesi",
            //    DayOfWeek.Tuesday=>"bu gün salı",
            //    DayOfWeek.Wednesday=>"bu gün çarşamba",
            //    DayOfWeek.Thursday=>"bu gün perşembe",
            //    DayOfWeek.Friday=>"bu gün cuma",
            //    DayOfWeek.Saturday=>"bu gün cumartesi",
            //    DayOfWeek.Sunday=>"bu gün pazar"

            //};
            //Console.WriteLine(mesaj);
            #endregion




            //Console.WriteLine(((true && true) || false && ((true ^ false) && false) || true));
            //Console.ReadLine();

            #region yeni yöntem

            //int i = 10;
            //string isim = i switch
            //{
            //    5 when 3 == 3 => "hilmi",
            //    var x when x == 7 && x % 2 == 1 => "rıfkı",
            //    10 => "gençay"
            //};

            #endregion

            #region tuple patterns

            //int s1 = 10;
            //int s2 = 20;

            //string mesaj = "";
            //switch (s1 , s2) 
            //{
            //    case 5:
            //        mesaj = "5 ile 10 değerleri";
            //        break;

            //}

            #endregion

            #region if yapısı

            //string a;
            //a= Console.();

            //if (a ==true) 
            //{
            //    Console.WriteLine();
            //}


            #endregion

            #region scopsuz if yapısı

            //if (true)
            //    Console.WriteLine("effwefe");

            #endregion

            #region try - catch yapılanması

            try
            {
                //olası çalışam zamanı hatalarını barındıran / verebilecek olan kodları buraya yazıyoruz.
            }
            catch (Exception)
            {

                //try içerisinde bir hata söz konusu oldugunda catch blogu tetiklenecektir.
                //hataya dair; log, kullanıcı bilgilendirme , konturölü kapanış.....
            }

            #endregion

            #region try - catch yapılanması - hata parmetreleri
            //çalışma zamanında alınan hataya dair bizlere bilgi veren/taşıyan parametrelerdir. 
            //try
            //{

            //}
            //catch (Exception ex)//ex parametre üzüerinden bizler alınan hataya dair bilgiler edinebilmekte ve gerekli loglama vs. / egerki tanımlama yapılırsa hata neticesinde catch calisacak lakkin bilgi alamayacagız

            //{



            //}

            #endregion

            #region exception dışında farklı bir tür ile hata ayıklama

            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int a = s1 / s2;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Mesaj : " + ex.Message);

            //}
            //Console.ReadLine();

            #endregion


            #region finally bloğu
            ////finally blogu try catch yapılanmasında hata alınsada alınmasada her iki durumda da tetiklenmesi / çalıştırıması gereken kodları yazdıgımız bloktur.
            //try
            //{
            //    // hata verebilecek kodlar buraya
            //}
            //catch (Exception)
            //{
            //    //hatadan sonra yapılacak işlemler buraya

            //}
            //finally
            //{
            //    //her iki durumda da çalışmasını istedigimiz kodlar buraya
            //}

            #endregion

            #region when yapısı ile hata filitreleme(c# 6.0)
            // try catch bloklarına whwen keywördü ile şart uygulayabilmekteyiz...
            string x = "c";
            try
            {
                int s1 = 0, s2 = 10;
                int a = s1 / s2;
            }
            catch (DivideByZeroException ex) when (x == "a")
            {
                Console.WriteLine("Mesaj : " + ex.Message);

            }

            catch (DivideByZeroException ex) when (x == "b")
            {
                Console.WriteLine("Mesaj : " + ex.Message);

            }

            catch (Exception ex) 
            {

            }
            Console.ReadLine();

            #endregion






            }
        }
    }
