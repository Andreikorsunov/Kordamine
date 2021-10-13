using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korsunovulesanded
{
    class Abivahend
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine(Alamprogramm.Korruta(3, 6));
            Double arv1 = 5;
            Double arv2 = 6;

            Double resultik = Alamprogramm.Eval(arv1.ToString() + "+" + arv2.ToString());
            Console.WriteLine(resultik);
            Console.ReadLine();
        }
    }
}
