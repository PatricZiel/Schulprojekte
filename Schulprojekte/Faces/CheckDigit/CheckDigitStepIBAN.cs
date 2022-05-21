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
using Schulprojekte.Objekte;
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
            initTooltipText();
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
                    CheckdigitSuccess(Language.CHECK_DIGIT_CORRECT_MESSAGE_IBAN);
                }
            }
        }

        private void InitializeCountries()
        {
            countries.Add("DE", 1314);
        }

        private void initTooltipText()
        {
            string lineBreak = "\n";
            string toolTipText =
                "IBAN" + lineBreak
              + "Bitte gib eine vollständige IBAN ein." + lineBreak
              + "Mindestens 22 Zeichen eingeben" + lineBreak
              + "Unterstützte Sprachen: ";
            foreach (KeyValuePair<string, int> entry in countries)
            {
                string languageAbbreviation = "language_for_abbreviation_";
                languageAbbreviation += entry.Key.ToLower();
                string language = GeneralLanguage.GetTranslationByKey(languageAbbreviation);

                toolTipText += lineBreak;
                toolTipText += " - ";
                toolTipText += StringHandler.firstLetterUpperCase(language);
            }
            ActivateToolTip(toolTipText);
        }
    }
}
