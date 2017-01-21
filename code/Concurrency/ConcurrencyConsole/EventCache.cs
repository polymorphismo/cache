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
            Console.WriteLine("EventCache starting...");
        }

        public static void Finish()
        {
            Console.WriteLine("EventCache is finished");
        }
    }
}
