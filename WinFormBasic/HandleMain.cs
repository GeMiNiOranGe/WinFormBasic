﻿using System;
using System.Windows.Forms;

namespace HandleMain {
    public static class HandleKeys {
        /// <summary>
        /// Allow number keys and control keys to pass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void txtBoxNum_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
    public static class HandleInput {
        /// <summary>
        /// If the string input is empty, return integer zero and otherwise
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public static int IntNumber(string strInput) {
            if (strInput != "") {
                return int.Parse(strInput);
            }
            return 0;
        }
    }
}