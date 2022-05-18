using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulprojekte.Handler;
using Schulprojekte.Resources;
using Schulprojekte.Resources.Language;
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.CheckDigit
{
    public partial class CheckDigitStepIBAN : CheckDigitStep
    {
        String iban = "";
        Dictionary<string, int> countries = new Dictionary<string, int>();

        public CheckDigitStepIBAN()
        {
            InitializeComponent();
            step = Constants.CURRENT_SITE_STEP_IBAN;
            InitializeCountries();
        }

        protected override void btn_validateButton_Click(object sender, System.EventArgs e)
        {
            String errorMessage = CheckDigitHandler.checkIban(iban, countries);

            if(errorMessage.Length > 0)
            {
                // Errormessage in oberfläche ausgeben
            } else
            {
                // Checkdigit gültig
            }
        }

        private void InitializeCountries()
        {
            countries.Add("DE", 1314);
        }
    }
}
