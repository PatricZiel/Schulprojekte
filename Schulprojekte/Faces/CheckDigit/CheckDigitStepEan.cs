using System;
using System.Drawing;
using System.Windows.Forms;
using Schulprojekte.Handler;
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

            fillInputs(Language.CHECK_DIGIT_EAN, Constants.NAME_FRAGMENT_CHECK_DIGIT);
            updateInputs();
        }

        protected override void btn_validateButton_Click(object sender, System.EventArgs e)
        {
            //get user input value
            string ean = ((TextBox)inputs[0].input_field).Text;
            
            string methodReply = CheckDigitHandler.checkEan(ean);

            if(methodReply.Length > 0)
            {
                CheckdigitError(methodReply);
            }
            else
            {
                CheckdigitSuccess(Language.CHECK_DIGIT_CORRECT_MESSAGE_EAN);
            }
        }
    }
}
