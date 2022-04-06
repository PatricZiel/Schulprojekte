using Schulprojekte.Handler;
using Schulprojekte.Resources;
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

namespace Schulprojekte.Faces.QuantitativeOfferComparison
{
    public partial class QuantitativeOfferComparisonStep3 : Step
    {
        public QuantitativeOfferComparisonStep3()
        {
            InitializeComponent();
            step = Constants.CURRENT_SITE_STEP_THREE;
        }
    }
}
