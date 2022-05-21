using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Handler
{
    internal class StringHandler
    {
        /*
         *
         * Erwartet einen string
         * Setzt den ersten Buchstaben des Strings in großschrift.
         * Returnt den convertierten String
         *
         */
        public static string firstLetterUpperCase(string word)
        {
            string returnValue = word.Substring(0, 1).ToUpper();
            returnValue += word.Remove(0, 1);
            return returnValue;
        }
    }
}
