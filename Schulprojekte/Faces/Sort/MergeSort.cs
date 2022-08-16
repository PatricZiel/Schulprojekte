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
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.Sort
{
    public partial class MergeSort : subTaskContent
    {
        public MergeSort()
        {
            InitializeComponent();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            SortHandler.mergeSortTest();
        }
    }
}
