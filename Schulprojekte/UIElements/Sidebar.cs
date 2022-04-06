using Schulprojekte.Handler;
using Schulprojekte.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Schulprojekte.UIElements
{
    public partial class Sidebar : UserControl
    {
        public Application container = null;
        public List<GoToProjectButton> projectButtons = new List<GoToProjectButton>();

        public Boolean isOpen = false;

        int panelOpenWidth = 200;
        int panelClosedWidth = 20;

        public Sidebar()
        {
            InitializeComponent();
        }

        public void toggleSidebar(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                // dreht das Panel-schließen-Icon
                pnl_toggleIcon.BackgroundImage = FacesHandler.rotateImage(global::Schulprojekte.Properties.Resources.greaterThan, 180);

                // transition um panel zu schließen
                while (Width > panelClosedWidth)
                {
                    Width -= 4;
                }

                // Globale Variable für die Offenstatus wird auf false gesetzt
                isOpen = false;
            }
            else
            {
                // dreht das Panel-öffnen-Icon
                pnl_toggleIcon.BackgroundImage = global::Schulprojekte.Properties.Resources.greaterThan;

                // transition um panel zu öffnen
                while (Width < panelOpenWidth)
                {
                    Width += 4;
                }

                // Globale Variable für die Offenstatus wird auf true gesetzt
                isOpen = true;
            }
        }

        public void onSidebarSizeChange(object sender, EventArgs e)
        {
            pnl_sidebarContent.Width = Width - panelClosedWidth;
            pnl_sidebarContent.Refresh();

            pnl_sidebarContentHeader.Width = pnl_sidebarContent.Width;
            pnl_sidebarContentHeader.Refresh();

            if(projectButtons != null)
            {
                foreach (Button btn in projectButtons)
                {
                    btn.Left = pnl_sidebarContent.Width - btn.Width;
                    btn.Refresh();
                }
            }
        }

        public void initSidebar(Application parent)
        {
            container = parent;
            addButtons(parent.initializeGoToButtons());
        }

        private void addButtons(List<GoToProjectButton> projectButtons)
        {
            this.projectButtons.AddRange(projectButtons);

            int buttonNumber = 0;
            foreach (GoToProjectButton projectButton in this.projectButtons)
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
            int spaceTop = 100;
            int spaceBetween = 1;

            projectButton.Width = panelOpenWidth - panelClosedWidth;
            projectButton.Height = 40;

            spaceTop += (projectButton.Height + spaceBetween) * buttonNumber;
            projectButton.Left = 0;
            projectButton.Top = spaceTop;

            projectButton.FlatStyle = FlatStyle.Flat;
            projectButton.FlatAppearance.BorderSize = 0;
            projectButton.ForeColor = Color.White;
            projectButton.TextAlign = ContentAlignment.MiddleLeft;

            projectButton.BackColor = Constants.COLORTEMPLATE_SIDEBARBUTTON_BACKGROUND;
            if(container != null)
            {
                projectButton.Click += new System.EventHandler(openSiteFromButton);
            }

            pnl_sidebarContent.Controls.Add(projectButton);
        }

        public void openSiteFromButton(object sender, EventArgs e)
        {
            foreach(GoToProjectButton goToProjectButton in projectButtons)
            {
                goToProjectButton.setSelected(false);
            }

            container.openSiteFromButton(sender, e);
        }
    }
}