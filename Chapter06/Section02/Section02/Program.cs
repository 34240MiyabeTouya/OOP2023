using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            var numbers = Enumerable.Range(1, 1000000).ToArray();
            WriteTotalMemory("配列確保後");


            //偶数だけ取り出す
            var evenNumber = numbers.Where(n => n % 2 == 0).ToArray();

            WriteTotalMemory("偶数抽出後");
            //foreach (var num in evenNumber) {
            //    Console.WriteLine("{0}",num);
            //}


            var ave = evenNumber.Average();
            WriteTotalMemory("偶数抽出後平均");
           


        }
        static void WriteTotalMemory(string header) {
            var totalMemory = GC.GetTotalMemory(true) / 1024.0 / 1024.0;
            Console.WriteLine($"{header}: {totalMemory:0.000 MB}");
        }
    }
}
