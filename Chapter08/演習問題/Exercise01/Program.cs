using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            //2019/1/15 19:48
            var day = string.Format("{0:yyyy/M/d HH:mm}",dateTime);
            Console.WriteLine(day);
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            //2019年01月15日
            var day = dateTime.ToString("D");
            Console.WriteLine(day);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            //平成31年　1月15日(火曜日)
            var cluture = new CultureInfo("ja-JP");
            cluture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = dateTime.ToString("ggyy年M月d日 (dddd)",cluture);
            Console.WriteLine(str);
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
        
        }
    }
}
