using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class GretingMorning :Greetingbase{
        public string GetMessage() {
            return "おはよう";
        }
    }

    class GreetingAfternoon :Greetingbase{
        public string GetMessage() {
            return "こんにちは";
        }
    }

    class GreetingEvening :Greetingbase{
        public string GetMessage() {
            return "こんばんは";
        }
    }
}
