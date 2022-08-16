using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Handler
{
    internal class ListHandler
    {
        public static void print(List<object> list)
        {
            foreach (object o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }
        public static void print(List<int> list)
        {
            foreach (object o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
