using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulprojekte.Resources;
using Schulprojekte.Resources.Language;
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.CheckDigit
{
    public partial class CheckDigitStepIBAN : Step
    {
        public CheckDigitStepIBAN()
        {
            InitializeComponent();
            step = Constants.CURRENT_SITE_STEP_IBAN;
            /*
            inputs.Add(new UserInput(Constants.NAME_FRAGMENT_CHECK_DIGIT, Language.CHECK_DIGIT, Constants.INPUT_TYPE_TEXT_BOX));
            alignInputsFromTop();
            foreach (UserInput userInput in inputs)
            {
                pnl_inputs.Controls.Add(userInput);
            }
            */
            btn_validateButton.Text = Language.CHECK_THE_CHECK_DIGIT;
        }

        private void btn_validateButton_Click(object sender, System.EventArgs e)
        {
            /*
            string iban = "DE88 2008 0000 0970 3757 00";
            string modifiedIban = "";
            string pruefziffer = "";
            int rest = 0;
            int nextrest = 0;
            int lastrest = 0;
            int valuedPruefziffer = 0;

            Dictionary<string, int> countries = new Dictionary<string, int>();
            countries.Add("DE", 1314);

            modifiedIban = iban.Replace(" ", "");
            modifiedIban = modifiedIban.Replace("-", "");
            pruefziffer = modifiedIban.Substring(2,2);

            modifiedIban = modifiedIban.Remove(0, 4);
            modifiedIban += countries["DE"] + "00"; 
        

        
            rest = Int32.Parse(modifiedIban.Substring(0, 9)) % 97;
            nextrest = Int32.Parse(rest.ToString() + modifiedIban.Substring(9, 8)) % 97;
            lastrest = Int32.Parse(nextrest.ToString() + modifiedIban.Substring(17, 7)) % 97;
            valuedPruefziffer = 98 - lastrest;


            Console.WriteLine(pruefziffer == valuedPruefziffer.ToString());
            */

        }
    }
}
