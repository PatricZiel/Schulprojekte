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

namespace Schulprojekte.UIElements
{
    public partial class subTaskTemplate : UserControl
    {
        public List<TabChangeButton> tabChangeButtons = new List<TabChangeButton>();

        public subTaskTemplate()
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

            spaceLeft += buttonNumber * (tabChangeButton.Width + spaceBetweenButtons);

            tabChangeButton.Top = spaceTop;
            tabChangeButton.Left = spaceLeft;

            tabChangeButton.Click += new System.EventHandler(openSiteFromButton);

            pnl_stepSwitch.Controls.Add(tabChangeButton);
        }

        private void openSiteFromButton(object sender, EventArgs e)
        {
            TabChangeButton projectButton = (TabChangeButton)sender;
            openSite(projectButton.destinationSite);

            //lbl_appHeader.Text = projectButton.Text;
        }

        // Öffnet die Seite/den Tab im dafür vorgesehenem Bereich
        public void openSite(UserControl userControl)
        {
            pnl_templateContent.Controls.Clear();
            pnl_templateContent.Controls.Add(userControl);
        }

        protected virtual List<TabChangeButton> initCheckDigitButtons()
        {
            // throw new NotImplementedException();
        }

        protected TabChangeButton generateTabChangebutton(string text, UserControl destination)
        {
            TabChangeButton checkdigitNavigateButton = new TabChangeButton();
            checkdigitNavigateButton.Name = "changeTab" + text;
            checkdigitNavigateButton.Text = text;
            checkdigitNavigateButton.destinationSite = destination;
            return checkdigitNavigateButton;
        }
    }
}
