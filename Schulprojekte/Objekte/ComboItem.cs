using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Objekte
{
    public partial class ComboItem
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public ComboItem()
        {

        }

        public ComboItem(int ID, string Text)
        {
            this.ID = ID;
            this.Text = Text;
        }
    }
}
