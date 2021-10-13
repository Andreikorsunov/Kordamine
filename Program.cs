using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korsunovulesanded
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Esimene ülesanne");

            Random rnd = new Random();
            int n = rnd.Next(1, 49);
            int m = rnd.Next(50, 100);
            Console.WriteLine($"{n}, {m}");
            int[] numbers = new int[m - n + 1];
            int t = 0;
            for (int i = n; i < m + 1; i++)
            {
                numbers[t] = i;
                Console.WriteLine($"{i} is the root of {i * i}, ");
                t++;
            }
            foreach (var j in numbers)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Teine ülesanne");
            int sum = 0;
            int mult = 1;
            double avg = 0.0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number: ");
                int smt = Convert.ToInt32(Console.ReadLine());
                sum += smt;
                mult = smt * mult;
            }
            avg = sum / 5;
            Console.WriteLine($"Nums AVG = {avg}\nNums SUM = {sum}\nNums multiplied = {mult}");

            Console.WriteLine("Kolmas Ülesanne");

            string text;
            do
            {
                Console.WriteLine("Oosta elevant");
                Console.Write("Oosta ");
                text = Console.ReadLine();
            } while (text != "elevant");
            Console.WriteLine("Sina ostid elevant");

            Console.WriteLine("Neljas ülesanne");

            int A = rnd.Next(1, 5);//arvuti arv
            int AA;//kasutaja arv
            int K = 1;//katsed
            do
            {
                Console.WriteLine("{0}. Katse. Mis arv?", K);
                AA = int.Parse(Console.ReadLine());
                K=K+1;
            } while (AA!=A && K!=6);
            if (AA == A)
            {
                Console.WriteLine("Palju õnne!"+A);
            }
            else
            {
                Console.WriteLine("Proovi veel!");
            }

            Console.ReadLine();
        }
    }
}
