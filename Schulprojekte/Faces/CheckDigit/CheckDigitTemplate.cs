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
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.CheckDigit
{
    public partial class CheckDigitTemplate : UserControl
    {
        Dictionary<string, Step> stepList = new Dictionary<string, Step>();
        public List<TabChangeButton> tabChangeButtons = new List<TabChangeButton>();

        public CheckDigitTemplate()
        {
            InitializeComponent();
            InitInnerTabview();
        }

        private void InitInnerTabview()
        {
            tabChangeButtons.AddRange(initCheckDigitButtons());
            addButtons();
            tabChangeButtons[0].PerformClick();
        }

        private void addButtons()
        {
            int buttonNumber = 0;
            foreach (TabChangeButton tabChangeButton in tabChangeButtons)
            {
                addTabChangeButton(tabChangeButton, buttonNumber);
                buttonNumber++;
            }
        }

        //Fügt ein 'TabChangeButton'-Objekt zur checkDigit-Seite hinzu
        /*
         * Parameter:
         * TabChangeButton - definiert den hinzuzufügenden Button
         * buttonNumber - Ergebnis eines zählers um die Button-Position zu bestimmen 
         *                  - Startet bei 0
         */
        private void addTabChangeButton(TabChangeButton tabChangeButton, int buttonNumber)
        {
            tabChangeButton.Width = 100;
            tabChangeButton.Height = 35;

            tabChangeButton.BackColor = Constants.COLORTEMPLATE_DASHBOARDBUTTON_BACKGROUND;

            int spaceBetweenButtons = 30;
            int spaceTop = 15;
            int spaceLeft = 15;
            /*
            if (buttonNumber > 3)
            {
                spaceTop += tabChangeButton.Height + spaceBetweenButtons;
                buttonNumber -= 4;
            }
            */
            spaceLeft += buttonNumber * (tabChangeButton.Width + spaceBetweenButtons);

            tabChangeButton.Top = spaceTop;
            tabChangeButton.Left = spaceLeft;

            tabChangeButton.Click += new System.EventHandler(openSiteFromButton);

            pnl_digitStepSwitch.Controls.Add(tabChangeButton);
        }

        private void openSiteFromButton(object sender, EventArgs e)
        {
            TabChangeButton projectButton = (TabChangeButton)sender;
            openSite(projectButton.destinationSite);

            lbl_contentHeader.Text = projectButton.Text;

            foreach (TabChangeButton tabChangeButton in tabChangeButtons)
            {
                tabChangeButton.setSelected(tabChangeButton.Name == projectButton.Name);
            }
        }

        // Öffnet die Seite/den Tab im dafür vorgesehenem Bereich
        public void openSite(UserControl userControl)
        {
            pnl_templateContent.Controls.Clear();
            pnl_templateContent.Controls.Add(userControl);
        }

        private List<TabChangeButton> initCheckDigitButtons()
        {
            List<TabChangeButton> checkDigitNavigateButtons = new List<TabChangeButton>();
            TabChangeButton checkdigitNavigateButton;


            checkdigitNavigateButton = new TabChangeButton();
            checkdigitNavigateButton.Name = "eanButton";
            checkdigitNavigateButton.Text = "EAN";
            checkdigitNavigateButton.destinationSite = new CheckDigitStepEan();
            checkDigitNavigateButtons.Add(checkdigitNavigateButton);

            checkdigitNavigateButton = new TabChangeButton();
            checkdigitNavigateButton.Name = "ibanButton";
            checkdigitNavigateButton.Text = "IBAN";
            checkdigitNavigateButton.destinationSite = new CheckDigitStepIBAN();
            checkDigitNavigateButtons.Add(checkdigitNavigateButton);

            return checkDigitNavigateButtons;
        }
    }
}
