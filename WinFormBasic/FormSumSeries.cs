﻿using System;
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
            StringBuilder strBResultPower = new StringBuilder();
            StringBuilder strBXPowerNum = new StringBuilder();
            double sum = 0;
            double n = HandleInput.IntNumber(inputN.Text);
            double x = HandleInput.IntNumber(inputX.Text);
            for (int i = 1; i <= n; i++) {
                double iNumTemp = Math.Pow(x, i);
                strBResultPower.Append(iNumTemp.ToString() + "+");
                sum += iNumTemp;
            }
            for (int i = 2; i <= n; i++) {
                strBXPowerNum.Append("X^" + i + "+");
            }
            string strPower = "", strResultPower = "";
            if (strBXPowerNum.ToString() != "") {
                strPower = "X+" + strBXPowerNum.ToString().Remove(strBXPowerNum.Length - 1);
            }
            if (strBResultPower.ToString() != "") {
                strResultPower = strBResultPower.ToString().Remove(strBResultPower.Length - 1);
            }
            txtBoxXPowerNum.Text = strPower;
            txtBoxNumPowerNum.Text = strPower.Replace("X", x.ToString());
            txtBoxResultPower.Text = strResultPower;
            outputResult.Text = sum.ToString();
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e) {
            HandleKeys.txtBoxNum_KeyPress(sender, e);
        }
    }
}
