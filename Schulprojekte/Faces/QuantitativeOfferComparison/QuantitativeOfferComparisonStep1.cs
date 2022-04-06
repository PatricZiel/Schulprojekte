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
    public partial class QuantitativeOfferComparisonStep1 : Step
    {
        public QuantitativeOfferComparisonStep1()
        {
            InitializeComponent();
            step = Constants.CURRENT_SITE_STEP_ONE;

            inputs.Add(new UserInput(Constants.NAME_FRAGMENT_OFFER_COUNT, "Anzahl an Angeboten", Constants.INPUT_TYPE_NUMERIC_UP_DOWN));
            inputs.Add(new UserInput(Constants.NAME_FRAGMENT_AMOUND, "Bestellmenge", Constants.INPUT_TYPE_NUMERIC_UP_DOWN, "1"));
            alignInputsFromTop();
            foreach(UserInput userInput in inputs)
            {
                pnl_inputs.Controls.Add(userInput);
            }
        }

        public bool submit()
        {
            bool validationFailure = false;

            foreach(UserInput userInput in inputs)
            {
                if(!userInput.submit()) validationFailure = true;
            }

            return validationFailure;
        }
    }
}
