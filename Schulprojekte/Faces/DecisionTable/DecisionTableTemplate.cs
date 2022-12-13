using Schulprojekte.Handler;
using Schulprojekte.Objekte;
using Schulprojekte.Resources;
using Schulprojekte.Resources.Language;
using Schulprojekte.UIElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Schulprojekte.Faces.DecisionTable {
    public partial class DecisionTableTemplate : UserControl {
        Step step = new DecisionTableStep1();
        int countPosition = 1;

        public DecisionTableTemplate() {
            InitializeComponent();
            StartFirstSite();
        }

        private void StartFirstSite() {
            //pnl_templateContent.Controls.Add(step);
            //colorStepbutton(btn_breadCrumbFirst);
        }

        public void continueStep(object sender, EventArgs e) {
            switch (step.step) {
                case Constants.CURRENT_SITE_STEP_ONE:
                    continueFromStepOne();
                    break;
                case Constants.CURRENT_SITE_STEP_TWO:
                    continueFromStepTwo();
                    break;
                case Constants.CURRENT_SITE_STEP_THREE:
                    continueFromStepThree();
                    break;
                default:
                    break;
            }
        }

        private void continueFromStepOne() {
            DecisionTableStep1 step = (DecisionTableStep1)this.step;
            //submit
            if (step.submit()) {
                return;
            }
        }

        private void continueFromStepTwo() {
            //DecisionTableStep2 step = (DecisionTableStep2)this.step;
            //submit
            //if (step.submit()) {
            //    return;
            //}
        }
        private void continueFromStepThree() {
            //step = new DecisionTableStep4();
        }

        private void colorStepbutton(RoundButton roundButton) {
            roundButton.BackColor = Color.FromArgb(16, 64, 105);
            roundButton.ForeColor = Color.White;
        }
    }
}
