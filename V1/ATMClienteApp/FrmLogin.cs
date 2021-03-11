using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMclassLibrary;
using System.Threading;
using System.Diagnostics;

namespace ATMClienteApp
{
    public partial class FrmLogin : Form
    {
        FrmStartup MYLOG = new FrmStartup();
        int cnt = 1;
        public bool outofservice = false;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            OutofServiceMode();
        }
        private void OutofServiceMode()
        {
            if (outofservice == false)
            {
                lboutofService.Visible = false;
                lbsorry.Visible = false;
            }
            else
            {
                lboutofService.Visible = true;
                lbsorry.Visible = true;
            }
        }
        public void btLogin_Click(object sender, EventArgs e)
        {
            atmManager atm = new atmManager();
            atm.loadBank();
            atm.loadCustomer();
            string name = txbName.Text;
            string pin = txbPin.Text;
            bool loginconfirm = atm.validateUser(name, pin);
            if (outofservice == false || name == "Admin")
            {
                if (txbName.Text == "" || txbPin.Text == "")
                {
                    MessageBox.Show("Please entry [Name] and [Password]", "Error: Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txbPin.Text = "";
                    this.txbName.Text = "";
                    txbPin.Clear();
                    txbName.Clear();
                }
                else if (loginconfirm == true && name != "Admin")
                {
                    this.txbPin.Text = "";
                    this.txbName.Text = "";
                    FrmAtmMain frmMain = new FrmAtmMain(pin, MYLOG, atm);
                    this.Hide();
                    frmMain.Show();
                    frmMain.Activate();
                }
                else if (loginconfirm == true && name == "Admin")
                {
                    this.txbPin.Text = "";
                    this.txbName.Text = "";
                    FrmAdmin frmAdmin = new FrmAdmin(pin, MYLOG, atm);
                    this.Hide();
                    frmAdmin.Show();
                    frmAdmin.Activate();
                }
                else if (loginconfirm == false && cnt < 3)
                {
                    cnt++;
                    MessageBox.Show("Sorry! \n The Name or Password is incorrect", "Error: User || Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPin.Clear();
                }
                else if (loginconfirm == false && cnt >= 3)
                {
                    MessageBox.Show("Sorry! \n Currently it is not possible to access your account \n Please try again later, Thank you", "Error: User || Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txbPin.Text = "";
                    this.txbName.Text = "";
                    txbPin.Clear();
                    txbName.Clear();
                }
            }
            else
            {
                txbName.Clear();
                txbPin.Clear();
                for (int i = 1; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.Beep();
                    lboutofService.Show();
                    lbsorry.Show();
                }
                lboutofService.Show();
                lbsorry.Show();
            }
        }
        private void btLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void txbPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}