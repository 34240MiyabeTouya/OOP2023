﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメートルの単位変換クラス
    public static　class FeetConverter {
        //定数
        private const double retio = 0.3048;

        //メートルからフィートを求める
        public static double FromMeter(double meter) {
            return meter / retio;
        }

        //フィートからメートルを求める
        public static double ToMeter(double feet) {
            return feet * retio;
        }
    }
}
