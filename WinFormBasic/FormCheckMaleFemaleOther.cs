using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBasic {
    public partial class frmCheckMaleFemaleOther : Form {
        public frmCheckMaleFemaleOther() {
            InitializeComponent();
        }

        private void checkBox_CheckedStateChanged(object sender, EventArgs e) {
            string choose = checkBox.CheckState == CheckState.Checked ?
                "male" : checkBox.CheckState == CheckState.Unchecked ?
                "famale" : "other";
            txtBoxOutput.Text = string.Format("You are {0}", choose);
        }
    }
}
