using System;
using System.Drawing;
using System.Windows.Forms;
using Schulprojekte.Resources;
using Schulprojekte.Resources.Language;
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.CheckDigit
{
    public partial class CheckDigitStepEan : CheckDigitStep
    {
        public CheckDigitStepEan()
        {
            InitializeComponent();
            step = Constants.CURRENT_SITE_STEP_EAN;
            
            inputs.Add(new UserInput(Constants.NAME_FRAGMENT_CHECK_DIGIT, Language.CHECK_DIGIT, Constants.INPUT_TYPE_TEXT_BOX));
            alignInputsFromTop();
            foreach (UserInput userInput in inputs)
            {
                pnl_inputs.Controls.Add(userInput);
            }
            
            btn_validateButton.Text = Language.CHECK_THE_CHECK_DIGIT;

            fillInputs("", "");
        }

        protected override void btn_validateButton_Click(object sender, System.EventArgs e)
        {
            //get user input value
            string ean = ((TextBox)inputs[0].input_field).Text;

            //check if contains only digits
            if (!int.TryParse(ean, out _))
            {
                CheckdigitError(Language.INPUT_INCORRECT + ": " + Language.PLEASE_USE_ONLY_DIGITS);
                return;
            }

            if(ean.Length != 13)
            { 
                CheckdigitError(Language.INPUT_INCORRECT + ": " + Language.LENGTH_IS_NOT_EXPECTED + ": 13");
                return;
            }

            string eanprüf = ean[12].ToString();
            int checksum = GetEAN(ean);

            int compareValue = 10 - checksum % 10;
            if(compareValue == 10)
            {
                compareValue = 0;
            }

            if (compareValue == int.Parse((eanprüf).ToString()))
            {
                lbl_resultMessage.Text = Language.CHECK_DIGIT_CORRECT_MESSAGE;
                lbl_resultMessage.ForeColor = Color.Green;
            }
            else
            {
                CheckdigitError(Language.CHECK_DIGIT_INCORRECT_MESSAGE);
            }
        }

        private int GetEAN(string eannr)
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
    }
}
