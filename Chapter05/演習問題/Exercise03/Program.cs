using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            Console.WriteLine(text.Where(s => s == ' ').Count());
        }


        private static void Exercise3_2(string text) {
            var str = text.Replace("big", "small");
            Console.WriteLine(str);
        }

        private static void Exercise3_3(string text) {
            int count = text.Split(' ').Length;
            Console.WriteLine("単語数:{0}", count);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in words) {
                Console.WriteLine(word);
            }
        }

        private static void Exercise3_5(string text) {
            var array = text.Split(' ').ToArray();
            var sb = new StringBuilder();
            if (array.Length > 0) {
                sb.Append(array[0]);
                foreach (var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
            

            }
            var createWords = sb.ToString();
            Console.WriteLine(createWords);
        }
    }
}
