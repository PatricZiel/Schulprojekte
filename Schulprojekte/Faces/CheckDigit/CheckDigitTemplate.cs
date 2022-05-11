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
        Step step = new CheckDigitStepEan();
        public CheckDigitTemplate()
        {
            InitializeComponent();
            StartFirstSite();
        }

        private void StartFirstSite()
        {
            pnl_templateContent.Controls.Add(step);
        }
    }
}
