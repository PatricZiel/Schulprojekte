using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schulprojekte.Objekte;
using Schulprojekte.UIElements;

namespace Schulprojekte.Faces.Verschlüsselung {
    public partial class HomophonicEncryptionTemplate : subTaskTemplate {
        Dictionary<char, int> encryption = new Dictionary<char, int>();
        public HomophonicEncryptionTemplate() {
            InitializeComponent();
            HomophomicEncryption encreyption = new HomophomicEncryption();
        }

        private void initHomophonicMap() {
            List<int> aList = new List<int>();
        }
    }
}
