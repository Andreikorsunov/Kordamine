using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korsunovulesanded
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(2, 6);
            int m = rnd.Next(7, 14);

            int[] mass = new int[(m - n)];
            for(int i= n; i < m+1; i++)
            {
                Console.Write("");
                mass[i - n] = i;
                Console.WriteLine(" {0} ", i * i);
            }
            foreach(var M in mass)
            {
                Console.WriteLine(m);
            }
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

            string text;
            do
            {
                Console.WriteLine("Oosta elevant");
                Console.Write("Oosta");
                text = Console.ReadLine();
            } while (text != "elevant");
            Console.WriteLine("Sina ostid elevant");


        }
    }
}
