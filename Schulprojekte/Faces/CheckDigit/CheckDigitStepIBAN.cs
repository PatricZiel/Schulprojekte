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
using Schulprojekte.Objekte;
using Schulprojekte.Resources;
using Schulprojekte.Resources.Language;
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.CheckDigit
{
    public partial class CheckDigitStepIBAN : CheckDigitStep
    {
        Dictionary<string, int> countries = new Dictionary<string, int>();

        public CheckDigitStepIBAN()
        {
            // Dynamisches generieren der Seite
            InitializeComponent();
            // Festlegen des internen Seitenstrings - Auf welcher seite bin ich?: IBAN
            step = Constants.CURRENT_SITE_STEP_IBAN;

            // Erzeugen der Eingabefelder
            fillInputs(Language.CHECK_DIGIT_IBAN, Constants.NAME_FRAGMENT_CHECK_DIGIT);
            updateInputs();

            // Länderunterstützung
            InitializeCountries();
            // Tooltip-Informationen
            initTooltipText();
        }

        // Was soll passieren, wenn der 'Prüfen'-Button geklickt wird?
        protected override void btn_validateButton_Click(object sender, System.EventArgs e)
        {
            string iban;
            // Prüfung des ersten (und einzigen) Eingabefeldes 
            // Die Prüfung ist generell in allen eingaben für jedes oberflächen Objekt erstellt.
            // Es wird geprüft, ob in dem feld ein 'holbarer' wert drin steht.
            // Parameter: false - die eingabe muss keine reine Zahl sein
            if(inputs[0].submit(false))
            {
                // Wenn die Prüfung problemlos durchläuft dann wird der Wert ausgelesen.
                iban = (string)inputs[0].getValue();

                // Prüfung der IBAN und rückgabe eines Fehlerstrings
                // Wenn rückgabestring leer, dann ist es Fehlerfrei durchgelaufen
                String errorMessage = CheckDigitHandler.checkIban(iban, countries);

                // Falls Fehler stattgefunden hat, wird dieser in der Oberfläche ausgeworfen
                if(errorMessage.Length > 0)
                {
                    CheckdigitError(errorMessage);
                } else
                {
                    // Ansonsten wird eine message angezeigt, dass die IBAN valide ist.
                    CheckdigitSuccess(Language.CHECK_DIGIT_CORRECT_MESSAGE_IBAN);
                }
            }
        }

        // Unterstützte länder und deren gegenüberliegender Wert werden in das globale Dictionary 'countries' geschrieben
        private void InitializeCountries()
        {
            countries.Add("DE", 1314);
        }

        // Erstellen eines Tooltip textes und anhand dynamische methoden kann dieses direkt an der richtigen Stelle in richtiger Form dargestellt werden.
        // Benötigt Methode: 'ActivateToolTip();' mit dem anzuzeigenden Text als Parameter
        private void initTooltipText()
        {
            string lineBreak = "\n";
            string toolTipText =
                "IBAN" + lineBreak
              + "Bitte gib eine vollständige IBAN ein." + lineBreak
              + "Mindestens 22 Zeichen eingeben" + lineBreak
              + "Unterstützte Sprachen: ";
            // Für jedes Land
            foreach (KeyValuePair<string, int> entry in countries)
            {
                // Ländernamen anhand der Abkürzung
                string languageAbbreviation = "language_for_abbreviation_";
                languageAbbreviation += entry.Key.ToLower();
                string language = GeneralLanguage.GetTranslationByKey(languageAbbreviation);
                // Anfügen der Länder in einer eigenen Zeile mit einem '-'-Symbol davor
                toolTipText += lineBreak;
                toolTipText += " - ";
                toolTipText += StringHandler.firstLetterUpperCase(language);
            }
            ActivateToolTip(toolTipText);
        }
    }
}
