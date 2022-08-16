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

namespace Schulprojekte.Faces.Sort
{
    public partial class SortTemplate : subTaskTemplate
    {
        public SortTemplate()
        {
            InitializeComponent();
        }

        protected override List<TabChangeButton> initCheckDigitButtons()
        {
            List<TabChangeButton> checkDigitNavigateButtons = new List<TabChangeButton>();

            checkDigitNavigateButtons.Add(generateTabChangebutton("Merge", new MergeSort()));

            return checkDigitNavigateButtons;
        }
    }
}
