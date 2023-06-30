using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbr = new Abbreviations();

            //Addメソッドの呼び出し
            abbr.Add("IOC", "国際オリンピック委員会");
            abbr.Add("NPT","核拡散防止条約");

            //7.2.3
            //上のメソッドで、２つのオブジェクトを追加している
            //読み込んだ単語数+2が、Countの値になる。
            Console.WriteLine(abbr.Count);
            Console.WriteLine();

            //7.2.3(Remaveの呼び出し)
            if (abbr.Remave("NPT")) 
                Console.WriteLine(abbr.Count);
            if (!abbr.Remave("NPT"))
                Console.WriteLine("削除できません");
            Console.WriteLine();

            //7.2.4
            //IEnumerable<>を実装したので、LINQが使える。
            foreach (var item in abbr.Where(abb => abb.Key.Length == 3)) {
                Console.WriteLine("{0}={1}",item.Key,item.Value);
            }
        }
    }
}
