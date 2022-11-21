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
    public partial class frmSimpleCalculate : Form {
        public frmSimpleCalculate() {
            InitializeComponent();
        }

        RadioButton FindRadioBtnIn(GroupBox grBox) {
            foreach (RadioButton item in grBox.Controls) {
                if (item.Checked) {
                    return item;
                }
            }
            return null;
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            RadioButton radioButton = FindRadioBtnIn(grBoxOperator);
            int para1st = HandleInput.IntNumber(txtBox1st.Text);
            int para2nd = HandleInput.IntNumber(txtBox2nd.Text);
            if (radioButton != null) {
                if (radioButton.Text == radioBtnSum.Text)
                    txtResult.Text = (para1st + para2nd).ToString();
                if (radioButton.Text == radioBtnSubtract.Text)
                    txtResult.Text = (para1st - para2nd).ToString();
                if (radioButton.Text == radioBtnMultiplication.Text)
                    txtResult.Text = (para1st * para2nd).ToString();
                if (radioButton.Text == radioBtnDivision.Text)
                    txtResult.Text = (para1st / para2nd).ToString();
            }
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e) {
            HandleKeys.txtBoxNum_KeyPress(sender, e);
        }
    }
}
