using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            Console.Write("1:店舗別売り上げ");
            Console.Write("2:商品カテゴリー別売り上げ");
            var num = Console.ReadLine();

            var sales = new SalesCounter(@"date\sales.csv");
            var amountPerStore = sales.GetPerStoreSales(num);
            foreach (var obj in amountPerStore) {
                Console.WriteLine("{0}{1:C}", obj.Key, obj.Value);
                 
            }
        }
    }
}
