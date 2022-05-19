using Schulprojekte.Resources;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Schulprojekte.UIElements
{
    public partial class TabChangeButton : Button
    {
        public UserControl destinationSite;
        public bool selected = false;

        public TabChangeButton()
        {

        }

        public void setSelected(bool select)
        {
            if (selected != select)
            {
                selected = select;

                if (selected)
                {
                    BackColor = Constants.COLORTEMPLATE_TABVIEWBUTTON_BACKGROUND_SELECTED;
                    ForeColor = Constants.COLORTEMPLATE_WHITE;
                }
                else
                {
                    BackColor = Constants.COLORTEMPLATE_TABVIEWBUTTON_BACKGROUND;
                    ForeColor = Constants.COLORTEMPLATE_BLACK;
                }
            }
        }
    }
}
