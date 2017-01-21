using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyConsole
{
    public class EventCache
    {
        public static  void Start()
        {
            string msg = "EventCache starting...";
            Console.WriteLine(msg);
        }

        public static void Finish()
        {
            Console.WriteLine("EventCache is finished");
        }
    }
}
