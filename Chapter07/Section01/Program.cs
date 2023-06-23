using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Dict = new Dictionary<string, CityInfo>();

            string pref;
            string city;
            int population;

            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名:");

            while (true) {
                pref = Console.ReadLine();
                if (pref == "999") break;

                Console.Write("所在地:");
                city = Console.ReadLine();

                Console.Write("人口:");
                population = int.Parse(Console.ReadLine());

                //重複チェック
                if (Dict.ContainsKey(pref)) {
                    Console.Write("既に県名が登録されています。");
                    Console.Write("上書きしますか(Y/N):");

                    if (Console.ReadLine() == "Y") {
                        Dict[pref] = new CityInfo {//上書き処理
                            City = city,
                            Population = population,
                        };
                    }
                } else {
                    Dict[pref] = new CityInfo {//登録処理
                        City = city,
                        Population = population,
                    };
                }
                Console.Write("県名:");
            }
            Console.Write("");
            Console.Write("1:一覧表示　2:県名指定　:");
            var num = Console.ReadLine();
            if (num == "1") {
                foreach (var item in Dict) {
                    Console.WriteLine("{0}【{1}({2})】", item.Key,item.Value.City,item.Value.Population);
                }
            } else if (num == "2") {
                Console.Write("県名を入力");
                string ken = Console.ReadLine();
                Console.WriteLine("【{0}({1})】です。", Dict[ken].City,Dict[ken].Population);
            }
        }
    }
    class CityInfo {
        public string City { get; set; }//都市
        public int Population { get; set; } //人口
    }
}
