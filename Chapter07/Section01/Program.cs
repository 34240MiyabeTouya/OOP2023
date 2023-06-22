using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Dict = new Dictionary<string,string>();

            string pref;
            string city;

            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名:");
            
            while (true) {
                pref = Console.ReadLine();
                if (pref == "999") break;
                Console.Write("所在地:");
                city = Console.ReadLine();
                Dict[pref] = city;
                Console.Write("県名:");
                
            }
            Console.Write("県名を入力:");
            string ken = Console.ReadLine();
            Console.WriteLine("{0}です。",Dict[ken]);
            
            
            

        }
    }
}
