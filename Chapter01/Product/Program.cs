﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
class Program {
        static void Main(string[] args) {
            //インスタンスの生成
            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(235, "大福もち", 160);
            Console.WriteLine("かりんとうの税込み価格" + karinto.GetPriceIncludingTax() + "円");
            Console.WriteLine("大福もちの税込み価格" + daifuku.GetPriceIncludingTax() + "円");
        }
    }
}
