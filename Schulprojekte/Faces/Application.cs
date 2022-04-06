using Schulprojekte.Faces;
using Schulprojekte.Faces.CheckDigit;
using Schulprojekte.Faces.QuantitativeOfferComparison;
using Schulprojekte.Resources;
using Schulprojekte.UIElements;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Schulprojekte
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
            sidebar.initSidebar(this);
            openDashboard();
        }

        // Öffnet die Dashboardseite
        public void openDashboard()
        {
            UserControl userControl = new Dashboard(this);
            openSite(userControl);
        }

        // Öffnet die Projektseite im dafür vorgesehenem Bereich
        public void openSite(UserControl userControl)
        {
            pnl_siteContent.Controls.Clear();
            pnl_siteContent.Controls.Add(userControl);
        }

        public void openSiteFromButton(object sender, EventArgs e)
        {
            GoToProjectButton projectButton = (GoToProjectButton) sender;
            openSite(projectButton.destinationSite);
            lbl_appHeader.Text = projectButton.Text;

            foreach (GoToProjectButton goToProjectButton in sidebar.projectButtons)
            {
                goToProjectButton.setSelected(goToProjectButton.Name == projectButton.Name);
            }
        }

        // Hinzufügen der Projekt-Weiterleitungsbuttons
        public List<GoToProjectButton> initializeGoToButtons()
        {
            List<GoToProjectButton> projectButtons = new List<GoToProjectButton>();
            GoToProjectButton projectButton;

            projectButton = new GoToProjectButton();
            projectButton.Name = "goToQuantitativeOfferComparison";
            projectButton.Text = Language_de.DBT_QUANTITATIVE_OFFERCOMPARISON;
            projectButton.destinationSite = new QuantitativeOfferComparisonTemplate();
            projectButtons.Add(projectButton);

            projectButton = new GoToProjectButton();
            projectButton.Name = "goToCheckDigit";
            projectButton.Text = Language_de.DBT_CHECK_DIGIT;
            projectButton.destinationSite = new CheckDigitTemplate();
            projectButtons.Add(projectButton);

            return projectButtons;
        }
    }
}
