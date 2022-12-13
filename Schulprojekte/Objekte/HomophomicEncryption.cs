using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Objekte {
    internal class HomophomicEncryption {
        Dictionary<char, int> charUsage = new Dictionary<char, int>();

        public HomophomicEncryption() {
            initCharUsage();
            writeRandomUsages();
        }

        /* private methods */
        /* "Eltern"-Methode zum erstellen einer Random Map */
        private void writeRandomUsages() {
            Dictionary<char, List<int>> charEncryption = new Dictionary<char, List<int>>();
            List<int> usedIntegers = new List<int>();
            Random rnd = new Random();
            foreach (KeyValuePair<char, int> entry in getCharUsage()) {
                List<int> encryptionList = new List<int>();
                for (int i = 0; i < entry.Value; i++) {
                    int randomNumber = rnd.Next(100, 1000);
                    while (usedIntegers.Contains(randomNumber)) {
                        randomNumber = rnd.Next(100, 1000);
                    }
                    usedIntegers.Add(randomNumber);
                    encryptionList.Add(randomNumber);
                }
                charEncryption.Add(entry.Key, encryptionList);
            }
            writeEncryptionToConsole(charEncryption);
        }

        /* 
         * Knüpft unterstützte Zeichen an häufigkeit 
         * um mehrere genutzte verschlüsselungen zu verwenden
         */
        private void initCharUsage() {
            getCharUsage().Add('a', 6);
            getCharUsage().Add('b', 2);
            getCharUsage().Add('c', 2);
            getCharUsage().Add('d', 5);
            getCharUsage().Add('e', 17);
            getCharUsage().Add('f', 2);
            getCharUsage().Add('g', 3);
            getCharUsage().Add('h', 5);
            getCharUsage().Add('i', 8);
            getCharUsage().Add('j', 1);
            getCharUsage().Add('k', 1);
            getCharUsage().Add('l', 3);
            getCharUsage().Add('m', 2);
            getCharUsage().Add('n', 10);
            getCharUsage().Add('o', 2);
            getCharUsage().Add('p', 1);
            getCharUsage().Add('q', 1);
            getCharUsage().Add('r', 7);
            getCharUsage().Add('s', 7);
            getCharUsage().Add('t', 6);
            getCharUsage().Add('u', 4);
            getCharUsage().Add('v', 1);
            getCharUsage().Add('w', 1);
            getCharUsage().Add('x', 1);
            getCharUsage().Add('y', 1);
            getCharUsage().Add('z', 1);

            getCharUsage().Add('?', 1);
            getCharUsage().Add('!', 1);
            getCharUsage().Add('.', 1);
            getCharUsage().Add(';', 1);
            getCharUsage().Add(',', 1);
        }
        private void writeEncryptionToConsole(Dictionary<char, List<int>> charEncryption) {
            Console.WriteLine("Dictionary<char, List<int>> charEncryption = new Dictionary<char, List<int>>();");

        /*
         * Schreibt die Verschlüsselung ALS CODE 
         * in die Console zum Copy-Pasten
         */
        private void writeEncryptionToConsole(Dictionary<string, List<string>> charEncryption) {
            Console.WriteLine("Dictionary<string, List<string>> charEncryption = new Dictionary<string, List<string>>();");
            Console.WriteLine("");
            Console.WriteLine("char writeChar;");
            Console.WriteLine("List<int> writeListForChar;");
            Console.WriteLine("");


            foreach (KeyValuePair<char, List<int>> entry in charEncryption) {
                Console.WriteLine("writeChar = " + entry.Key);
                Console.WriteLine("writeListForChar = new List<int>();");
                foreach (int i in entry.Value) {
                    Console.WriteLine("writeListForChar.Add(" + i + ")");
                }
                Console.WriteLine("charEncryption.Add(wirteChar, writeListForChar);");
                Console.WriteLine("");
            }
        }

        /*
         * Erzeugt 3 random Characters
         * für die verschlüsselung
         */
        private string generateRandomChars() {
            Random rnd = new Random();
            string returnValue = "";

            string lastused = "";

            for (int encLength = 0; encLength < Constants.ENCRYPTION_LENGTH; encLength++) {
                while (lastused.Equals(returnValue)) {
                    switch (rnd.Next(0, 3)) {
                        case 0:
                            returnValue += rnd.Next(0, 10).ToString();
                            break;
                        case 1:
                            string[] rndChars = { "a", "b", "c", "d", "e",
                            "f", "g", "h", "i", "j", "k", "l", "m", "n",
                            "o", "p", "q", "r", "s", "t", "u", "v", "w",
                            "x", "y", "z", "ä", "ö", "ü", "ß"};
                            string returnString = rndChars[rnd.Next(0, rndChars.Length)];
                            switch (rnd.Next(0, 2)) {
                                case 0:
                                    returnValue += returnString;
                                    break;
                                case 1:
                                    returnValue += returnString.ToUpper();
                                    break;
                            }
                            break;
                        case 2:
                            string[] rndSpecials = {".", ",", "?", "/", "\\\\", ";", ":",
                            "+", "-", "_", " ", "*", "#", "'", "~", "(", ")", "!",
                            "\\\"", "§", "$", "%", "&", "[", "]", "{", "}"};
                            returnValue += rndSpecials[rnd.Next(0, rndSpecials.Length)];
                            break;
                    }
                }
                lastused = returnValue;
            }
            return returnValue;
        }

        /* Getter und Setter */
        public Dictionary<char, int> getCharUsage() {
            return this.charUsage;
        }

        public void setCharUsage() {
            throw new Exception("charUsage sollte nicht neu gesetzt werden");
        }
    }
}
