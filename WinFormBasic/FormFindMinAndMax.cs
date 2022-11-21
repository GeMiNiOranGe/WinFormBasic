using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HandleMain;

namespace WinFormBasic {
    public partial class frmFindMinAndMax : Form {
        public frmFindMinAndMax() {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e) {
            int a = HandleInput.IntNumber(txtBoxInputA.Text);
            int b = HandleInput.IntNumber(txtBoxInputB.Text);
            int c = HandleInput.IntNumber(txtBoxInputC.Text);
            List<int> iList = new List<int>() { a, b, c };
            txtBoxOutputMax.Text = iList.Max().ToString();
            txtBoxOutputMin.Text = iList.Min().ToString();
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e) {
            HandleKeys.txtBoxNum_KeyPress(sender, e);
        }
    }
}
