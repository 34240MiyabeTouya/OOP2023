using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {

#if NonArray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
#elif StringArray
            string[] lines = {
                 "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            }
            
#endif  
            var nove = "Novelist=";
            var best = "BestWork=";
            var born = "Born=";

            var startIndex1 = line.IndexOf(nove) + nove.Length;
            var endIndex1 = line.IndexOf(";", startIndex1);
            var nolist = line.Substring(startIndex1, endIndex1 - startIndex1);

            var startIndex2 = line.IndexOf(best) + best.Length;
            var endIndex2 = line.IndexOf(";", startIndex2);
            var bestWork = line.Substring(startIndex2, endIndex2 - startIndex2);

            var startIndex3 = line.IndexOf(born) + born.Length;
            var Born = line.Substring(startIndex3, line.Length - startIndex3);

            Console.WriteLine("作家　：" + nolist);
            Console.WriteLine("代表作　：" + bestWork);
            Console.WriteLine("誕生年　：" + Born);
        }
    }
}
