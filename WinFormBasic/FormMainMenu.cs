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
    public partial class frmMainMenu : Form {
        public frmMainMenu() {
            InitializeComponent();
        }

        //pictureBox1.Image = new Bitmap(Application.StartupPath.Replace(@"\bin\Debug", string.Empty) + @"\icon\PopCat.gif");

        private void btnSumSeries_Click(object sender, EventArgs e) {
            new frmSumSeries().Show();
        }

        private void btnSum2Para_Click(object sender, EventArgs e) {
            new frmSimpleCalculate().Show();
        }

        private void btnCheckMFO_Click(object sender, EventArgs e) {
            new frmCheckMaleFemaleOther().Show();
        }

        private void btnAddName_Click(object sender, EventArgs e) {
            new frmAddNames().Show();
        }

        private void btnFindMaxAndMin_Click(object sender, EventArgs e) {
            new frmFindMinAndMax().Show();
        }

        private void btnReadNumbers_Click(object sender, EventArgs e) {
            new frmReadNumbers().Show();
        }

        private void btnCreateForm_Click(object sender, EventArgs e) {
            new frmCreateCustomForm().Show();
        }

        private void btnMenuFood_Click(object sender, EventArgs e) {
            new frmMenuFood().Show();
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void maximunSizeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }
        }

    }
}
