using Schulprojekte.Resources;
using System.Windows.Forms;

namespace Schulprojekte.UIElements
{
    public partial class GoToProjectButton : Button
    {
        public UserControl destinationSite;
        public bool selected = false;

        public GoToProjectButton()
        {

        }

        public void setSelected(bool select)
        {
            if(selected != select)
            {
                selected = select;

                if (selected)
                {
                    BackColor = Constants.COLORTEMPLATE_SIDEBARBUTTON_BACKGROUND_Selected;
                }
                else
                {
                    BackColor = Constants.COLORTEMPLATE_SIDEBARBUTTON_BACKGROUND;
                }
            }
        }
    }
}
