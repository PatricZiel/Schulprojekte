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

        }
    }
}
