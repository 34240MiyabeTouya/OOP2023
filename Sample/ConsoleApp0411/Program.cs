using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {
            Console.Write("金額:");
            int match = int.Parse(Console.ReadLine());
            Console.Write("支払:");
            int pay = int.Parse(Console.ReadLine());
            int change = pay - match;
            Console.Write("一万円:");
            for (int i = 0; i < change / 10000; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 10000;
            Console.Write("五千円:");
            for (int i = 0; i < change / 5000; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 5000;
            Console.Write("二千円:");
            for (int i = 0; i < change / 2000; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 2000;
            Console.Write("千円:");
            for (int i = 0; i < change / 1000; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 1000;
            Console.Write("五百円:");
            for (int i = 0; i < change / 500; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 500;
            Console.Write("百円:");
            for (int i = 0; i < change / 100; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 100;
            Console.Write("五十円:");
            for (int i = 0; i < change / 50; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 50;
            Console.Write("十円:");
            for (int i = 0; i < change / 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 10;
            Console.Write("五円:");
            for (int i = 0; i < change / 5; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 5;
            Console.Write("一円:");
            for (int i = 0; i < change / 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            change %= 1;
            Console.Write("お釣:" + (pay - match) + "円");
        }
        private static void astOut(int count) {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
