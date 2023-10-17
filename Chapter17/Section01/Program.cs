﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var greetings = new List<Greetingbase>() {
                new GretingMorning(),
                new GreetingAfternoon(),
                new GreetingEvening(),
            };
            foreach (var obj in greetings) {
                string msg = obj.GetMessage();
                Console.WriteLine(msg);
            }
        }
    }
}
