using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static void Main(string[] args) {
            var numberes = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            int count = Count(numberes, delegate (int n) { return n % 2 == 0; });
            Console.WriteLine(count);
        }

        public static int Count(int[] numberes, Predicate<int> judge) {
            int count = 0;
            foreach (var n in numberes) {
                if (judge(n) == true) {
                    count++;
                }
            }
            return count;
        }
    }
}
