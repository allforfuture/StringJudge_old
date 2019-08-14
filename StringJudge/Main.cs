using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringJudge
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Text = Text + "_" + Application.ProductVersion.ToString();
        }

        private void TxtSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
            {
                return;
            }
            if (txtSN.Text.Length < 24)
            {
                MessageBox.Show("SN号不能少于24位，请重新输入");
                return;
            }
            int startInt = Convert.ToInt16(txtStartInt.Text);
            int endInt = Convert.ToInt16(txtEndInt.Text);
            string snStr = txtSN.Text.Substring(startInt, endInt- startInt);
            if (snStr == txtJudgeStr.Text)
            {
                txtSN.Text = "";
                lblResult.Text = "OK";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "NG";
                lblResult.ForeColor = Color.Red;
            }
        }

        private void BtnLock_Click(object sender, EventArgs e)
        {
            txtStartInt.ReadOnly = txtEndInt.ReadOnly = txtJudgeStr.ReadOnly = !txtStartInt.ReadOnly;          
        }
    }
}
