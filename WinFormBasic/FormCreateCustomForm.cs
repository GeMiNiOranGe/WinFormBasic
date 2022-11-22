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
    public partial class frmCreateCustomForm : Form {
        public frmCreateCustomForm() {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            int row, column;
            if (!int.TryParse(txtBoxRow.Text, out row)) {
                row = 1;
            }
            if (!int.TryParse(txtBoxColumn.Text, out column)) {
                column = 1;
            }
            frmOutputCreated frm = new frmOutputCreated(row, column);
            frm.ShowDialog();
        }
    }
}
