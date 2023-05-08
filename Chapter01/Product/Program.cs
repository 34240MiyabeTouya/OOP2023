using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
class Program {
        static void Main(string[] args) {
            #region P26のサンプルプログラム
            //インスタンスの生成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(235, "大福もち", 160);

            //Console.WriteLine("かりんとうの税込み価格" + karinto.GetPriceIncludingTax() + "円");
            //Console.WriteLine("大福もちの税込み価格" + daifuku.GetPriceIncludingTax() + "円");
            #endregion
            DateTime date = new DateTime(2023,5, 8);

            //現在
            DateTime dateNaw = DateTime.Now;
            Console.WriteLine("今日の日付は" + dateNaw.Day + "日です。");

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("今日の10日後は" + daysAfter10.Day + "日です。");

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);
            Console.WriteLine("今日の10日前は" + daysBefore10.Day + "日です。");
        }
    }
}
