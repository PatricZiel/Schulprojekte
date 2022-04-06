using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Resources
{
    internal class Constants
    {
        // Color template
        //Dashboard
        public static Color COLORTEMPLATE_DASHBOARDBUTTON_BACKGROUND = Color.FromArgb(220, 220, 255);
        //Sidebar
        public static Color COLORTEMPLATE_SIDEBARBUTTON_BACKGROUND = Color.FromArgb(25, 100, 150);
        public static Color COLORTEMPLATE_SIDEBARBUTTON_BACKGROUND_Selected = Color.FromArgb(18, 75, 115);

        // Current site
        public const String CURRENT_SITE_STEP_ONE = "step1";
        public const String CURRENT_SITE_STEP_TWO = "step2";
        public const String CURRENT_SITE_STEP_THREE = "step3";
        public const String CURRENT_SITE_STEP_FOUR = "step4";

        // Inputtype
        public const String INPUT_TYPE_NUMERIC_UP_DOWN = "num_up_down";
        public const String INPUT_TYPE_TEXT_BOX = "text_box";
        public const String INPUT_TYPE_COMBO_BOX = "combo_box";

        // Name Fragments
        // Step1
        public const String NAME_FRAGMENT_OFFER_COUNT = "offerCount";
        public const String NAME_FRAGMENT_AMOUND = "amound";
        // Step2
        public const String NAME_FRAGMENT_UNIT_PRICE = "unitPrice";
        public const String NAME_FRAGMENT_DELIVERY_DISCOUNT = "deliveryDiscount";
        public const String NAME_FRAGMENT_DELIVERY_SKONTO = "deliverySkonto";
        public const String NAME_FRAGMENT_PURCHASE_COST = "purchaseCost";

        // Deliverers
        public const String DELIVERER_HERMES = "Hermes";
        public const String DELIVERER_DHL = "DHL";
        public const String DELIVERER_DPD = "DPD";
        public const String DELIVERER_SELF = "Selbstabholung";
    }
}
