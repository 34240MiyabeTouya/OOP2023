using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //グラムを表すクラス
    public class GramsUnit : DistanceUnit {
        private static List<GramsUnit> units = new List<GramsUnit> {
            new GramsUnit{Name = "g",Coefficient = 1,},
            new GramsUnit{Name = "kg",Coefficient = 1000,},
        };
        public static ICollection<GramsUnit> Units { get { return units; } }

        /// <summary>
        /// ポンド単位からグラム単位に変換します
        /// </summary>
        /// <param name="unit">ポンド単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>
        public double FromPoundUnit(PoundUnit unit, double value) {
            return (value * unit.Coefficient) * 453.592 / this.Coefficient;
        }
    }
}
