using Schulprojekte.Resources.Language;
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
                return Language.CHECK_DIGIT_ERROR_IBAN_EMPTY;
                // Fehlermeldung: iban nicht befüllt
            }
            else if (!countries.ContainsKey(iban.Substring(0, 2)))
            {
                return Language.CHECK_DIGIT_ERROR_NO_LANGUAGE_SUPPORT;
                // Fehlermeldung: Land nicht unterstützt
            }

            if (!validation)
            {
                return errorMessage;
            }

            string modifiedIban = "";
            string pruefziffer = "";
            long rest = 0;
            long nextrest = 0;
            long lastrest = 0;
            long valuedPruefziffer = 0;

            modifiedIban = iban.Replace(" ", "");
            modifiedIban = modifiedIban.Replace("-", "");
            pruefziffer = modifiedIban.Substring(2, 2);

            modifiedIban = modifiedIban.Remove(0, 4);
            modifiedIban += countries[iban.Substring(0, 2)] + "00";



            rest = long.Parse(modifiedIban.Substring(0, 9)) % 97;
            nextrest = long.Parse(rest.ToString() + modifiedIban.Substring(9, 8)) % 97;
            lastrest = long.Parse(nextrest.ToString() + modifiedIban.Substring(17, 7)) % 97;
            valuedPruefziffer = 98 - lastrest;

            if(pruefziffer != valuedPruefziffer.ToString())
            {
                errorMessage = Language.CHECK_DIGIT_ERROR_INCORRECT;
            }

            return errorMessage;
        }
    }
}
