using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static void Main(string[] args) {
            var numberes = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            //5の倍数カウント
            int count = numberes.Count(n => n % 5 == 0 && n > 0);
            //合計値
            var sum = numberes.Where(n => n % 2 == 0).Average();
            Console.WriteLine(count);
        }
    }
}
