using Schulprojekte.Handler;
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
using WindowsFormsApplication1;

namespace Schulprojekte.Faces.QuantitativeOfferComparison
{
    public partial class QuantitativeOfferComparisonTemplate : UserControl
    {
        Step step = new QuantitativeOfferComparisonStep1();
        QuantitativeOfferComparisonInformation offerInformation = new QuantitativeOfferComparisonInformation();
        int countPosition = 1;

        public QuantitativeOfferComparisonTemplate()
        {
            InitializeComponent();
            StartFirstSite();
        }

        private void StartFirstSite()
        {
            pnl_templateContent.Controls.Add(step);
            colorStepbutton(btn_breadCrumbFirst);
        }

        public void continueStep(object sender, EventArgs e)
        {
            switch(step.step)
            {
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

        private void continueFromStepOne()
        {
            QuantitativeOfferComparisonStep1 step = (QuantitativeOfferComparisonStep1) this.step;
            //submit
            if (step.submit())
            {
                return;
            }

            foreach(UserInput userInput in step.inputs)
            {
                switch (userInput.userInputName) {
                    case Constants.NAME_FRAGMENT_OFFER_COUNT:
                        offerInformation.offerCount = Convert.ToInt32(userInput.getValue());
                        break;
                    case Constants.NAME_FRAGMENT_AMOUND:
                        offerInformation.amound = Convert.ToInt32(userInput.getValue());
                        break;
                }
            }

            this.step = new QuantitativeOfferComparisonStep2();
            ((QuantitativeOfferComparisonStep2)this.step).setOfferName("Angebot " + countPosition);
            pnl_templateContent.Controls.Clear();
            pnl_templateContent.Controls.Add(this.step);
            colorStepbutton(btn_breadCrumbSecond);
        }

        private void continueFromStepTwo()
        {
            QuantitativeOfferComparisonStep2 step = (QuantitativeOfferComparisonStep2) this.step;
            //submit
            if (step.submit())
            {
                return;
            }
            QuantitativeOfferComparisonOfferInformation offerInformation = new QuantitativeOfferComparisonOfferInformation();

            offerInformation.offererName = step.getOfferName();

            foreach(UserInput userInput in step.inputs)
            {
                switch(userInput.userInputName)
                {
                    case Constants.NAME_FRAGMENT_UNIT_PRICE:
                        offerInformation.unitPrice = TypeHandler.parseStringToDouble((string) userInput.getValue());
                        break;
                    case Constants.NAME_FRAGMENT_DELIVERY_DISCOUNT:
                        offerInformation.deliverer = (string) userInput.getValue();
                        offerInformation.deliveryDiscount = getDeliveryDiscountByDeliverer(offerInformation.deliverer);
                        break;
                    case Constants.NAME_FRAGMENT_DELIVERY_SKONTO:
                        offerInformation.deliverySkonto = TypeHandler.parseStringToDouble((string)userInput.getValue());
                        break;
                    case Constants.NAME_FRAGMENT_PURCHASE_COST:
                        offerInformation.purchaseCost = TypeHandler.parseStringToDouble((string)userInput.getValue());
                        break;
                }
            }

            this.offerInformation.offerInformations.Add(offerInformation);

            if(countPosition < this.offerInformation.offerCount)
            {
                countPosition++;
                pnl_templateContent.Controls.Clear();
                this.step = new QuantitativeOfferComparisonStep2();
                ((QuantitativeOfferComparisonStep2) this.step).setOfferName("Angebot " + countPosition);
                pnl_templateContent.Controls.Add(this.step);
            } else
            {
                this.step = new QuantitativeOfferComparisonStep3();
                pnl_templateContent.Controls.Clear();
                pnl_templateContent.Controls.Add(this.step);
                this.step.Controls.Add(FacesHandler.prepareConclusionTable(this.offerInformation));
                colorStepbutton(btn_breadCrumbThird);
            }
        }
        private void continueFromStepThree()
        {
            step = new QuantitativeOfferComparisonStep4();
            pnl_templateContent.Controls.Clear();
            pnl_templateContent.Controls.Add(step);

            btn_continueToNextSite.Hide();
            colorStepbutton(btn_breadCrumbFourth);
        }

        private void colorStepbutton(RoundButton roundButton)
        {
            roundButton.BackColor = Color.FromArgb(16, 64, 105);
            roundButton.ForeColor = Color.White;
        }

        private double getDeliveryDiscountByDeliverer(String deliverer)
        {
            switch(deliverer)
            {
                case Constants.DELIVERER_HERMES: // Hermes
                    return 1;
                case Constants.DELIVERER_DHL: // DHL
                    return 0;
                case Constants.DELIVERER_DPD: // DPD
                    return 2;
                case Constants.DELIVERER_SELF: // Selbstabholung
                    return 5;
            }
            Console.WriteLine("QuantitativeOfferComparisonTemplate.getDeliveryDiscountByDeliverer(ComboItem). Deliverer out of Bounds: " + deliverer);
            return 0;
        }
    }
}
