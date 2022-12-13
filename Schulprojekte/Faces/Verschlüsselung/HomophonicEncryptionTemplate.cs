using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulprojekte.Objekte;
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.Verschlüsselung {
    public partial class HomophonicEncryptionTemplate : subTaskTemplate {
        Dictionary<char, int> encryption = new Dictionary<char, int>();
        public HomophonicEncryptionTemplate() {
            InitializeComponent();
            //new HomophomicEncryption();
        }

        /* 
         * Methode zum Verschlüsseln des 
         * im Textfeld eingegebenen Strings
         */
        public void Encrypt(object sender, EventArgs e) {
            string inputValue = input_value.Text;
            string converted = "";
            string last = "";
            string that = "";
            foreach (char c in inputValue) {
                that = GetEnsirat().getNumber(c.ToString());
                while (that == last) {
                    last = GetEnsirat().getNumber(c.ToString());
                }
                last = that;
                converted += that;
            }

            input_value.Text = converted;
            decrypt.Enabled = true;
            encrypt.Enabled = false;
        }

        /* 
         * Methode zum Entschlüsseln des 
         * im Textfeld eingegebenen Strings
         */
        public void Decrypt(object sender, EventArgs e) {
            string inputValue = input_value.Text;
            string decryptedText = "";
            List<string> strings = new List<string>();

            KeyValuePair<string, string[]> firstChiffreEntry = DicUtils.GetKeyValuePair(GetEnsirat().GetChiffre());
            int valueLength = firstChiffreEntry.Value[0].Length;
            for (int i = 0; i < inputValue.Length; i += valueLength) {
                strings.Add(inputValue.Substring(i, valueLength));
            }
            foreach (string s in strings) {
                decryptedText += ensirat.getChar(s);
            }
            input_value.Text = decryptedText;
            decrypt.Enabled = false;
            encrypt.Enabled = true;
        }

        public void SetEensirat(Ensirat newEnsirat) {
            ensirat = newEnsirat;
        }

        public Ensirat GetEnsirat() {
            return ensirat;
        }
    }
}
