using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    //インチとメートルの単位変換クラス
    public static　class InchConverter {
        //定数
        private const double retio = 0.0254;

        //メートルからインチを求める
        public static double FromMeter(double meter) {
            return meter / retio;
        }

        //インチからメートルを求める
        public static double ToMeter(double feet) {
            return feet * retio;
        }
    }
}
