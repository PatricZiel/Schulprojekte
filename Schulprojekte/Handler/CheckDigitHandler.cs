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
        /*
         *
         * Methode um die gültigkeit der angegebenen EAN zu checken.
         * 
         * Parameter - ean: String
         * Die angegebene und zu überprüfende IBAN
         *
         * Rückgabetyp - string
         * Enthält beim Fehlerfall eine Fehlermeldung welche in der Oberfläche abgefangen wird 
         * NOTIZ: Nur der erste auftretende Fehlerfall wird auf einmal angezeigt.
         * Ist der Rückgabestring leer, dann lief die Prüfung ohne Fehler.
         *
         */

        public static string checkEan(string ean)
        {
            // IBAN muss befüllt sein
            if (ean.Equals(""))
            {
                return Language.CHECK_DIGIT_ERROR_EAN_EMPTY;
            }

            //check if contains only digits
            if (!long.TryParse(ean, out _))
            {
                return Language.PLEASE_USE_ONLY_DIGITS;
            }

            if (ean.Length != 13)
            {
                return Language.LENGTH_IS_NOT_EXPECTED + ": 13";
            }

            string eanprüf = ean[12].ToString();
            long checksum = GetEAN(ean);

            long compareValue = 10 - checksum % 10;
            if (compareValue == 10)
            {
                compareValue = 0;
            }

            if (compareValue != long.Parse(eanprüf))
            {
                return Language.CHECK_DIGIT_INCORRECT_MESSAGE_EAN;
            }

            return "";
        }

        /*
         *
         * Eigendliche Methode zur Prüfung der EAN
         *
         */
        private static int GetEAN(string eannr)
        {
            int result = 0;
            string eanAsString = eannr.ToString();
            for (int i = 0; i < (eanAsString.Length - 1); i++)
            {
                if (i % 2 > 0)
                {
                    result += int.Parse(eanAsString[i].ToString()) * 3;
                    //* 3
                }
                else
                {
                    result += int.Parse(eanAsString[i].ToString()) * 1;
                    //* 1
                }
            }
            return result;
        }

        /*
         *
         * Methode um die gültigkeit der angegebenen IBAN zu checken.
         * 
         * Parameter - iban: String
         * Die angegebene und zu überprüfende IBAN
         * Parameter - countries: Dictionary<string, int>
         * Eine Map aller Länderkürzungen und deren Tauschwerten.
         *
         * Rückgabetyp - string
         * Enthält beim Fehlerfall eine Fehlermeldung welche in der Oberfläche abgefangen wird 
         * NOTIZ: Nur der erste auftretende Fehlerfall wird auf einmal angezeigt.
         * Ist der Rückgabestring leer, dann lief die Prüfung ohne Fehler.
         *
         */

        public static string checkIban(string iban, Dictionary<string, int> countries)
        {
            // IBAN muss befüllt sein
            if (iban.Equals(""))
            {
                return Language.CHECK_DIGIT_ERROR_IBAN_EMPTY;
            }
            // IBAN muss 22 Zeichen lang sein
            else if (iban.Length != 22)
            {
                return Language.LENGTH_IS_NOT_EXPECTED + ": 22";
            }
            // Die Länderkürzung muss in unserer Länderliste gefunden werden
            else if (!countries.ContainsKey(iban.Substring(0, 2)))
            {
                return Language.CHECK_DIGIT_ERROR_NO_LANGUAGE_SUPPORT;
            }

            // In den folgenden Zeilen geschieht die IBAN Prüfung
            string modifiedIban = removeUnwantedIbanSymbols(iban);
            string pruefziffer = modifiedIban.Substring(2, 2);
            long rest = 0;
            long nextrest = 0;
            long lastrest = 0;
            long valuedPruefziffer = 0;

            modifiedIban = modifiedIban.Remove(0, 4);
            modifiedIban += countries[iban.Substring(0, 2)] + "00";
            rest = long.Parse(modifiedIban.Substring(0, 9)) % 97;
            nextrest = long.Parse(rest.ToString() + modifiedIban.Substring(9, 8)) % 97;
            lastrest = long.Parse(nextrest.ToString() + modifiedIban.Substring(17, 7)) % 97;
            valuedPruefziffer = 98 - lastrest;

            // Validierung der angegebenen Prüfziffer
            if (int.Parse(pruefziffer) != valuedPruefziffer)
            {
                return Language.CHECK_DIGIT_INCORRECT_MESSAGE_IBAN;
            }

            return "";
        }

        /*
         *
         * Entfernt unerwünschte Symbole aus der IBAN, wie z.B. leerzeilen oder '-' Zeichen,
         * welche i.d.R. alle 4 Zeichen eingefügt werden
         *
         */
        private static string removeUnwantedIbanSymbols(string iban)
        {
            iban = iban.Replace(" ", "");
            iban = iban.Replace("-", "");

            return iban;
        }
    }
}
