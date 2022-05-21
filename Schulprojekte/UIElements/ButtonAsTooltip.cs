using Schulprojekte.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Schulprojekte.UIElements
{
    public partial class ButtonAsTooltip : Button
    {
        private ToolTip toolTip = new ToolTip();
        string buttonText = "";

        public ButtonAsTooltip(string toolTipText)
        {
            InitStyle(toolTipText);
        }

        /* Style */
        private void InitStyle(string toolTipText)
        {
            // Default style
            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            Text = "i";
            // Default größe
            Font = new System.Drawing.Font("Courier New", 11F);
            Size = new System.Drawing.Size(32, 32);
            // Tooltips sollen in der Tabreihenfolge nicht vorkommen
            TabIndex = 0; 

            MouseEnter += HoverStart;
            MouseLeave += hoverEnd;

            //ToolTip
            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 300;
            toolTip.ReshowDelay = 300;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this, toolTipText);
        }

        private void HoverStart(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            ForeColor = Constants.COLORTEMPLATE_TABVIEWBUTTON_BACKGROUND_SELECTED;
        }
        private void hoverEnd(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
            ForeColor = Constants.COLORTEMPLATE_BLACK;
        }

        /* Getter und Setter */
        public void setButtonText(string text)
        {
            buttonText = text;
        }

        public string getButtonText()
        {
            return buttonText;
        }
    }
}
