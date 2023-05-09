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
            #region 演習１
            //DateTime date = new DateTime(2023, 5, 8);

            ////現在
            //DateTime dateNaw = DateTime.Now;
            //Console.WriteLine("今日の日付:" + date.Year + "年" + date.Month + "月" + dateNaw.Day + "日です。");

            ////10日後を求める
            //DateTime daysAfter10 = date.AddDays(10);
            //Console.WriteLine("今日の10日後:" + daysAfter10.Year + "年" + daysAfter10.Month + "月" + daysAfter10.Day + "日です。");

            ////10日前を求める
            //DateTime daysBefore10 = date.AddDays(-10);
            //Console.WriteLine("今日の10日前:" + daysBefore10.Year + "年" + daysBefore10.Month + "月" + daysBefore10.Day + "日です。");
            #endregion

            Console.WriteLine("誕生日を入力");
            Console.Write("西暦：");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            var month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            var day = int.Parse(Console.ReadLine());
            DateTime birth = new DateTime(year, month, day);
            DateTime now = DateTime.Now;
            TimeSpan timespan = now - birth;
            Console.Write("あなたは生まれてから今日までで" + timespan.Days + "日目です");
        }
    }
}
