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
    public partial class frmSumSeries : Form {
        public frmSumSeries() {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            int sum = 0;
            int n = HandleInput.IntNumber(input.Text);
            for (int i = 1; i <= n; i++) {
                sum += i;
            }
            output.Text = sum.ToString();
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e) {
            HandleKeys.txtBoxNum_KeyPress(sender, e);
        }
    }
}
