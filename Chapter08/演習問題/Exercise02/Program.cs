using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var sumday = 0;
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                var day = NextWeek(DateTime.Today.AddDays(sumday), (DayOfWeek)dayofweek);
                Console.WriteLine("{0}の次週の{1}:{2}", DateTime.Today, dayofweek, day);
                sumday++;
            }
        }

        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 0) {
                days += 7;
            }
            return date.AddDays(days);
        }

    }
}
