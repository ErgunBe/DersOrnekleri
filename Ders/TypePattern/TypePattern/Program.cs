using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region type pattern

            object x = "ergün";

            if (x is string a)
            {
                Console.WriteLine(a);//a değişkenini ifin dışında da çagırabilirz ama hata verir çünkü null olabilecegi için hata verir
            }

            #endregion

            #region var pattern

            object v = "asderty";
            var c = "dfafafa";

            //var keywordu ile var patternde ki var yapılanması arasında davranis farkı vardır.
            //var keywordu : derleme zamanında turunu belirlerken
            //var patternda ki var keywordu ise : runtime da turunu belirleyecektir
            if (v is var b)
            {

            }

            #endregion
        }
    }
}
