using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulprojekte.UIElements
{
    public partial class Step : UserControl
    {
        public List<UserInput> inputs = new List<UserInput>();
        public String step = "";

        public Step() => InitializeComponent();

        public void alignInputsFromTop()
        {
            int inputCount = 0;
            foreach (UserInput userInput in inputs)
            {
                userInput.Top = userInput.Height * inputCount;
                inputCount++;
            }
        }
    }
}
