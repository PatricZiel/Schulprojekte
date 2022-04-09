using Schulprojekte.Faces;
using Schulprojekte.Faces.CheckDigit;
using Schulprojekte.Faces.QuantitativeOfferComparison;
using Schulprojekte.Objekte;
using Schulprojekte.Resources;
using Schulprojekte.Resources.Language;
using Schulprojekte.UIElements;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Schulprojekte
{
    public partial class Application : Form
    {
        public Application()
        {
            //Default language = german
            GeneralLanguage.changeLanguage(Constants.GL_DE);
            this.Paint += includeIconFont;

            InitializeComponent();
            sidebar.initSidebar(this);
            openDashboard();
        }

        private void includeIconFont(object sender, PaintEventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            //Extracting icon fonts from the WF Fabric.ttf file and adding into system memory.
            Stream fontAsStream = this.GetType().Assembly.GetManifestResourceStream("Schulprojekte.Resources.SyncfusionIcons.syncfusionIcon.ttf");
            byte[] fontAsByte = new byte[fontAsStream.Length];
            fontAsStream.Read(fontAsByte, 0, (int)fontAsStream.Length);
            fontAsStream.Close();
            IntPtr memPointer = System.Runtime.InteropServices.Marshal.AllocHGlobal(System.Runtime.InteropServices.Marshal.SizeOf(typeof(byte)) * fontAsByte.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontAsByte, 0, memPointer, fontAsByte.Length);
            pfc.AddMemoryFont(memPointer, fontAsByte.Length);
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
            projectButton.Text = Language.DBT_QUANTITATIVE_OFFER_COMPARISON;
            projectButton.destinationSite = new QuantitativeOfferComparisonTemplate();
            projectButtons.Add(projectButton);

            projectButton = new GoToProjectButton();
            projectButton.Name = "goToCheckDigit";
            projectButton.Text = Language.DBT_CHECK_DIGIT;
            projectButton.destinationSite = new CheckDigitTemplate();
            projectButtons.Add(projectButton);

            return projectButtons;
        }
    }
}
