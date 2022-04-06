using Schulprojekte.Objekte;
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
    public partial class QuantitativeOfferComparisonStep2 : Step
    {
        public QuantitativeOfferComparisonStep2()
        {
            InitializeComponent();
            step = Constants.CURRENT_SITE_STEP_TWO;

            inputs.Add(new UserInput(Constants.NAME_FRAGMENT_UNIT_PRICE, "Stückpreis", Constants.INPUT_TYPE_TEXT_BOX));

            UserInput delivererComboBox = new UserInput(Constants.NAME_FRAGMENT_DELIVERY_DISCOUNT, "Lieferant", Constants.INPUT_TYPE_COMBO_BOX);
            
            /*delivererComboBox.addComboBoxItems(new ComboItem[]
            {
                new ComboItem(1, "Hermes"),
                new ComboItem(2, "DHL" ),
                new ComboItem(3, "DPD" ),
                new ComboItem(4, "Selbstabholung")
            });*/
            ((ComboBox)delivererComboBox.input_field).Items.AddRange(new object[] {
                Constants.DELIVERER_HERMES,
                Constants.DELIVERER_DHL,
                Constants.DELIVERER_DPD,
                Constants.DELIVERER_SELF
            });

            inputs.Add(delivererComboBox);
            inputs.Add(new UserInput(Constants.NAME_FRAGMENT_DELIVERY_SKONTO, "Lieferskonto (in %)", Constants.INPUT_TYPE_TEXT_BOX));
            inputs.Add(new UserInput(Constants.NAME_FRAGMENT_PURCHASE_COST, "Bezugskosten", Constants.INPUT_TYPE_TEXT_BOX));
            alignInputsFromTop();
            foreach (UserInput userInput in inputs)
            {
                pnl_inputs.Controls.Add(userInput);
            }
        }
        public bool submit()
        {
            bool validationFailure = false;

            foreach (UserInput userInput in inputs)
            {
                if (!userInput.submit()) validationFailure = true;
            }

            return validationFailure;
        }

        public string getOfferName()
        {
            return input_offerName.Text;
        }

        public void setOfferName(String offerName)
        {
            input_offerName.Text = offerName;
        }
    }
}
