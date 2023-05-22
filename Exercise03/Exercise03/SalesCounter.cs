using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class SalesCounter {

        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }


        //店舗別売り上げを求める
        public IDictionary<string, int> GetPerStoreSales(string num) {
            var dict = new Dictionary<string, int>();
            if (num == 1) {
                foreach (var sale in _sales) {
                    if (dict.ContainsKey(sale.ShopName)) {
                        dict[sale.ShopName] += sale.Amount;//商品が既に存在する
                    } else {
                        dict[sale.ShopName] = sale.Amount;//商品が存在する
                    }
                }
            } else {
                foreach (var sale in _sales) {
                    if (dict.ContainsKey(sale.productCategory)) {
                        dict[sale.productCategory] += sale.Amount;//カテゴリ名が既に存在する
                    } else {
                        dict[sale.productCategory] = sale.Amount;//カテゴリ名が存在する
                    }
                }
            }
            return dict;
        }

    }

    //売り上げデータを読み込み、Saleオブジェクトのlistを返す
    static List<Sale> ReadSales(string filePath) {
        var sales = new List<Sale>(); //売り上げデータを格納する
        var lines = File.ReadAllLines(filePath); //ファイルからすべてのデータを読み込む

        foreach (string line in lines) {//すべての行から一行ずつ取り出す
            var items = line.Split(','); //区切りで項目別に分ける
            //Saleインスタンスを生成
            var sale = new Sale { ShopName = items[0], productCategory = items[1], Amount = int.Parse(items[2]) };
            sales.Add(sale); //Saleインスタンスをコレクションに追加
        }
        return sales;
    }
}

