using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Handler
{
    public class CheckDigitHandler
    {
        public static String checkIban(String iban, Dictionary<string, int> countries)
        {
            String errorMessage = "";
            Boolean validation = true;
            if (iban.Equals(""))
            {
                return "iban nicht befüllt";
                // Fehlermeldung: iban nicht befüllt
            }
            else if (!countries.ContainsKey(iban.Substring(0, 2)))
            {
                return "Land nicht unterstützt";
                // Fehlermeldung: Land nicht unterstützt
            }

            if (!validation)
            {
                return errorMessage;
            }

            string modifiedIban = "";
            string pruefziffer = "";
            int rest = 0;
            int nextrest = 0;
            int lastrest = 0;
            int valuedPruefziffer = 0;

            modifiedIban = iban.Replace(" ", "");
            modifiedIban = modifiedIban.Replace("-", "");
            pruefziffer = modifiedIban.Substring(2, 2);

            modifiedIban = modifiedIban.Remove(0, 4);
            modifiedIban += countries[iban.Substring(0, 2)] + "00";



            rest = Int32.Parse(modifiedIban.Substring(0, 9)) % 97;
            nextrest = Int32.Parse(rest.ToString() + modifiedIban.Substring(9, 8)) % 97;
            lastrest = Int32.Parse(nextrest.ToString() + modifiedIban.Substring(17, 7)) % 97;
            valuedPruefziffer = 98 - lastrest;

            if(pruefziffer != valuedPruefziffer.ToString())
            {
                //errorMessage = ""
            }

            return errorMessage;
        }
    }
}
