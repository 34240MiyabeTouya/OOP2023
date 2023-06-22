using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Dict = new Dictionary<string, string>();

            string pref;
            string city;

            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名:");

            while (true) {
                pref = Console.ReadLine();
                if (pref == "999") break;

                Console.Write("所在地:");
                city = Console.ReadLine();
                //重複チェック
                if (Dict.ContainsKey(pref)) {
                    Console.Write("既に県名が登録されています。");
                    Console.Write("上書きしますか(Y/N):");

                    if (Console.ReadLine() == "Y") {
                        Dict[pref] = city;//上書き処理
                    }
                } else {
                    Dict[pref] = city;//登録処理
                }
                Console.Write("県名:");

            }
            Console.Write("1:一覧表示　2:県名指定　:");
            if (Console.ReadLine() == "1") {
                foreach (var item in Dict) {
                    Console.WriteLine("{0}({1})", item.Key, item.Value);
                }
            } else if (Console.ReadLine() == "2") {
                Console.Write("県名を入力");
                string ken = Console.ReadLine();
                Console.WriteLine("{0}です。", Dict[ken]);
            }
        }
        class cityInfo {
            string City { get; set; }
            int Population { get; set; }
        }
    }
}
