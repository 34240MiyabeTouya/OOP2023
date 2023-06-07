using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 2, 5, 7, 8, 9, 5, 2, };

            var books = Books.GetBooks();
            Console.WriteLine(numbers.Average());

            var booksObj = books.Where(x => x.Title.Contains("物語")).Average(x=>x.Pages);

            Console.WriteLine("平均{0}ページ", booksObj);

            var longTitleBooks = books.OrderByDescending(x => x.Title.Length);
            foreach (var book in longTitleBooks) {
                Console.WriteLine("{0}{1}円",book.Title,book.Price);
            }
        }
    }
}

