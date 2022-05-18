using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.CheckDigit
{
    public partial class CheckDigitTemplate : UserControl
    {
        Dictionary<string, Step> stepList = new Dictionary<string, Step>();
        String currentStep = "EAN";

        public CheckDigitTemplate()
        {
            InitializeComponent();
            initStepList();
            StartFirstSite();
        }

        private void StartFirstSite()
        {
            pnl_templateContent.Controls.Add(stepList[currentStep]);
        }

        private void initStepList()
        {
            stepList.Add("EAN", new CheckDigitStepEan());
            stepList.Add("IBAN", new CheckDigitStepIBAN());
        }
    }
}
