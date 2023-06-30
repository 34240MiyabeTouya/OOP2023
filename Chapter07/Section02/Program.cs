using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            
            var Dict = new Dictionary<string, List<CityInfo>>();

            string pref;
            string city;
            int population;


            Console.WriteLine("都市の登録");
            Console.Write("県名:");

            while (true) {
                pref = Console.ReadLine();
                if (pref == "999") break;

                Console.Write("都市:");
                city = Console.ReadLine();

                Console.Write("人口:");
                population = int.Parse(Console.ReadLine());

                //市町村インスタンスの生成
                var cityinfo = new CityInfo {
                    City = city,
                    Population = population
                };


                if (Dict.ContainsKey(pref)) {
                    //List<CityInfo>が登録済みのためaddでデータを追加
                    Dict[pref].Add(cityinfo);

                } else {
                    //List<CityInfo>が存在しないため、Listを作成(new)してデータを登録
                    Dict[pref] = new List<CityInfo> { cityinfo };
                }
                Console.Write("県名:");
            }
            Console.Write("1:一覧表示　2:県名指定　:");
            var num = Console.ReadLine();
            if (num == "1") {
                foreach (var item in Dict) {
                    foreach (var item1 in item.Value.OrderByDescending(n => n.Population)) {
                        Console.WriteLine("{0}【{1}(人口:{2})】", item.Key, item1.City, item1.Population);
                    }
                }
            } else if (num == "2") {
                Console.Write("県名を入力:");
                var ken = Console.ReadLine();
                foreach (var item in Dict[ken].OrderByDescending(n => n.Population)) {
                    Console.WriteLine("{0}【{1}(人口:{2})】", ken, item.City, item.Population);
                }
            }
        }
    }
    class CityInfo {
        public string City { get; set; }//都市
        public int Population { get; set; } //人口
    }
}

