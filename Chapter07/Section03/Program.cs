using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {

           var abbrs =  new Abbreviations();


            //Addメソッドの呼び出し例

            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT","核兵器不拡散条約");

            //インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NTP" };
            foreach (var name in names) {
                var fullname = abbrs[name];
                if (fullname ==null) {
                    Console.WriteLine("{0}は見つかりません", name);
                } else {
                    Console.WriteLine("{0}={1}",name,fullname);
                }
                Console.WriteLine();//改行
            }

            //ToAbbrebiationメソッドの利用例
            var japanees = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanees);
            if (abbreviation == null) {
                Console.WriteLine("{0}は見つかりません", japanees);
            } else {
                Console.WriteLine("{0}={1}", japanees, abbreviation);
            }


            //FillAllメソッドの利用例
            foreach (var item in abbrs.FindAll("国際")) {
                Console.WriteLine("{0}={1}",item.Key,item.Value);
            }
            Console.WriteLine();
        }
    }
}
