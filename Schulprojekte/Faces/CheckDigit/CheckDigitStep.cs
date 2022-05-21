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
    public partial class CheckDigitStep : Step
    {
        string userinputNameFragment = "";
        string userinputLabel = "";
        string userinputInputtype = Constants.INPUT_TYPE_TEXT_BOX;

        private ButtonAsTooltip tool_information;

        public CheckDigitStep()
        {
            InitializeComponent();
        }

        protected void updateInputs()
        {
            inputs = new List<UserInput>();

            inputs.Add(new UserInput(userinputNameFragment, userinputLabel, userinputInputtype));
            alignInputsFromTop();
            foreach (UserInput userInput in inputs)
            {
                pnl_inputs.Controls.Add(userInput);
            }

            btn_validateButton.Text = Language.CHECK_THE_CHECK_DIGIT;
        }

        protected virtual void btn_validateButton_Click(object sender, System.EventArgs e)
        {

        }

        protected void CheckdigitError(String errorMessage)
        {
            lbl_resultMessage.Text = errorMessage;
            lbl_resultMessage.ForeColor = Color.Red;
        }

        protected void CheckdigitSuccess()
        {
            CheckdigitSuccess(Language.CHECK_DIGIT_CORRECT_MESSAGE);
        }

        protected void CheckdigitSuccess(String meessage)
        {
            lbl_resultMessage.Text = meessage;
            lbl_resultMessage.ForeColor = Color.Green;
        }

        protected void fillInputs(String label, String nameFragment)
        {
            this.userinputLabel = label;
            this.userinputNameFragment = nameFragment;
        }

        protected void ActivateToolTip(string toolTipText)
        {
            tool_information = new ButtonAsTooltip(toolTipText);

            tool_information.Location = new System.Drawing.Point(860, 123);
            tool_information.Name = "tool_information";

            Controls.Add(tool_information);
        }
    }
}
