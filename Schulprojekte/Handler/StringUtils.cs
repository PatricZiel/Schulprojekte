using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Handler
{
    internal class StringUtils
    {
        public static bool notEmptyTrimmed(string s)
        {
            bool isNnotEmptyTrimmed = true;

            if(s == null
                ||s.Trim().Length == 0)
            {
                isNnotEmptyTrimmed = false;
            }

            return isNnotEmptyTrimmed;
        }
    }
}
