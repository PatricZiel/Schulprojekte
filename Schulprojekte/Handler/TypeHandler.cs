using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Handler
{
    internal class TypeHandler
    {


        public static double parseStringToDouble(string s)
        {
            if (s != null && s != "")
                return double.Parse(s);
            return 0.0;
        }
    }
}
