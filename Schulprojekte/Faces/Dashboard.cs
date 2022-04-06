using Schulprojekte.Resources;
using Schulprojekte.UIElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Schulprojekte.Faces
{
    public partial class Dashboard : UserControl
    {
        Application container;
        public List<GoToProjectButton> projectButtons = new List<GoToProjectButton>();

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(Application parent)
        {
            InitializeComponent();
            container = parent;
            projectButtons.AddRange(parent.initializeGoToButtons());
            addButtons();
        }

        private void addButtons()
        {
            int buttonNumber = 0;
            foreach(GoToProjectButton projectButton in projectButtons)
            {
                addDashboardButton(projectButton, buttonNumber);
                buttonNumber++;
            }
        }

        //Fügt ein 'GoToProjectButton'-Objekt zur Dashboardseite hinzu
        /*
         * Parameter:
         * GoToProjectButton - definiert den hinzuzufügenden Button
         * buttonNumber - Ergebnis eines zählers um die Button-Position zu bestimmen 
         *                  - Startet bei 0
         *                  - Für einen Maximalwert von 7 ausgelegt
         */
        private void addDashboardButton(GoToProjectButton projectButton, int buttonNumber)
        {
            projectButton.Width = 200;
            projectButton.Height = 200;

            projectButton.BackColor = Constants.COLORTEMPLATE_DASHBOARDBUTTON_BACKGROUND;

            int spaceBetweenButtons = 30;
            int spaceTop = 50;
            int spaceLeft = 50;

            if (buttonNumber > 3)
            {
                spaceTop += projectButton.Height + spaceBetweenButtons;
                buttonNumber -= 4;
            }

            spaceLeft += buttonNumber * (projectButton.Width + spaceBetweenButtons);

            projectButton.Top = spaceTop;
            projectButton.Left = spaceLeft;

            projectButton.Click += new System.EventHandler(openSiteFromButton);

            Controls.Add(projectButton);
        }

        public void openSiteFromButton(object sender, EventArgs e)
        {
            container.openSiteFromButton(sender, e);
        }
    }
}
