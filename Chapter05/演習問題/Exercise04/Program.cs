using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };



#endif

#if NonArray
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
#elif StringArray
            foreach (var line in lines) {
                foreach (var pair in line.Split(';')) {
                    var array = pair.Split('=');
                    Console.WriteLine("{0}:{1}", ToJapanese(array[0]), array[1]);
                }
            }



#endif

            static string ToJapanese(string key) {
                switch (key) {
                    case "Novelist";
                        return "作家";
                    case "BestWork";
                        return "代表作";
                    case "Born";
                        return "誕生年";
                }
                throw new ArgumentException("正しい引数ではありません");
            }

        }
    }

}

