using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulprojekte.Handler;
using Schulprojekte.Resources;
using Schulprojekte.Resources.Language;
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.CheckDigit
{
    public partial class CheckDigitStepIBAN : CheckDigitStep
    {
        Dictionary<string, int> countries = new Dictionary<string, int>();

        public CheckDigitStepIBAN()
        {
            InitializeComponent();
            step = Constants.CURRENT_SITE_STEP_IBAN;

            fillInputs(Language.CHECK_DIGIT_IBAN, Constants.NAME_FRAGMENT_CHECK_DIGIT);
            updateInputs();

            InitializeCountries();
        }

        protected override void btn_validateButton_Click(object sender, System.EventArgs e)
        {
            string iban;
            if(inputs[0].submit(false))
            {
                iban = (string)inputs[0].getValue();
            
                String errorMessage = CheckDigitHandler.checkIban(iban, countries);

                if(errorMessage.Length > 0)
                {
                    CheckdigitError(errorMessage);
                } else
                {
                    // Checkdigit gültig
                }
            }
        }

        private void InitializeCountries()
        {
            countries.Add("DE", 1314);
        }
    }
}
