using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyConsole
{
    public class EventCache
    {
        private const string moduleName = "EventCache";
        public static  void Start()
        {
            Console.WriteLine(moduleName + " starting...");
        }

        public static void Finish()
        {
            Console.WriteLine(moduleName + " finished");
        }
    }
}
