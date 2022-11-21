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

        private void pictureBox1_Click(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\icon\\PopCat.gif");
        }
    }
}
