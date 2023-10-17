using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

        }

        private static void Exercise1_2() {
            var price = Library.Books.Max(b => b.Price);
            var books = Library.Books.Where(c => c.Price == price);
            foreach (var item in books) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_3() {
            var year = Library.Books.GroupBy(b => b.PublishedYear)
                                    .Select(g=>new { PublishedYear = g.Key,Count = g.Count() })
                                    .OrderBy(x =>x.PublishedYear);
            foreach (var books in year) {
                Console.WriteLine("{0}年 {1}冊",books.PublishedYear,books.Count);
            }
        }

        private static void Exercise1_4() {
            var quary = Library.Books.
                                Join(Library.Categories,
                                book => book.CategoryId,
                                category => category.Id,
                                (book, category) => new { 
                                    PublishedYear = book.PublishedYear,
                                    book.Price,
                                    book.Title,
                                    CategoryaName = category.Name,
                                })
                                .OrderByDescending(x=>x.PublishedYear)
                                .ThenByDescending(x=>x.Price)
                                ;
            foreach (var item in quary) {
                Console.WriteLine("{0}年{1}円{2}({3})",
                                    item.PublishedYear,
                                    item.Price,
                                    item.Title,
                                    item.CategoryaName
                                    );
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books
                               .Where(b => b.PublishedYear == 2016)
                               .Join(Library.Categories,
                                     book => book.CategoryId,
                                     category => category.Id,
                                     (book, category) => category.Name)
                               .Distinct();

            foreach (var name in names) {
                Console.WriteLine(name);
            }

        }

        private static void Exercise1_6() {
            var quary = Library.Books.
                                Join(Library.Categories,
                                book => book.CategoryId,
                                category => category.Id,
                                (book, category) => new {
                                    PublishedYear = book.PublishedYear,
                                    book.Title,
                                    CategoryaName = category.Name,
                                })
                                .GroupBy(x => x.CategoryaName)
                                .OrderBy(x => x.Key);

            foreach (var group in quary) {
                Console.WriteLine("#{0}",group.Key);
                foreach (var item in group) {
                    Console.WriteLine("{0}", item.Title);
                }
            }

        }

        private static void Exercise1_7() {
            var catid = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books
                                .Where(b => b.CategoryId == catid)
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(b => b.Key);
            foreach (var group in groups) {
                Console.WriteLine("#{0}年", group.Key);
                foreach (var book in group) {
                    Console.WriteLine("{0}", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories
                                .GroupJoin(Library.Books,
                                            c => c.Id,
                                            b => b.CategoryId,
                                            (c, b) => new {
                                                categoryName = c.Name,
                                                Count = b.Count()
                                            })
                                .Where(x => x.Count >= 4);
            foreach (var categry in query) {
                Console.WriteLine(categry.categoryName);
            }
        }
    }
}
