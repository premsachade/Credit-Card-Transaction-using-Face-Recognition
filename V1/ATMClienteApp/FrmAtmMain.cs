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

namespace ATMClienteApp
{
    public partial class FrmAtmMain : Form
    {
        int cnt = 0, cnt1 = 0, c = 3, s = 3;
        decimal amount1 = 0, amount2 = 0;
        string pin;
        FrmStartup mylog;
        atmManager atm = new atmManager();
        decimal availabelATMmoney;
        public FrmAtmMain(string PIN, FrmStartup MYLOG, atmManager ATM)
        {
            InitializeComponent();
            pin = PIN;
            mylog = MYLOG;
            atm = ATM;
        }
        public void FrmAtmMain_Load(object sender, EventArgs e)
        {
            rdbtFromCurrent.Checked = true;
            availabelATMmoney = atm.bank.acBalance;
            txbAmount.Focus();
        }
        private void btCheckBalance_Click(object sender, EventArgs e)
        {
            if (rdbtFromSaving.Checked == true)
            {
                DisplayAccount_s();
                riseNewtransaction();
            }
            else if (rdbtFromCurrent.Checked == true)
            {
                DisplayAccount_c();
                riseNewtransaction();
            }
        }
        private void btMiniStatement_Click(object sender, EventArgs e)
        {
            if (rdbtFromSaving.Checked == true)
            {
                txbAccountinfo.Text = "Please collect your receipt";
                riseNewtransaction();
            }
            else if (rdbtFromCurrent.Checked == true)
            {
                txbAccountinfo.Text = "Please collect your receipt";
                riseNewtransaction();
            }
        }
        public void DisplayAccount_s()
        {
            txbAccountinfo.Clear();
            decimal savbal = atm.savingAccount.acBalance;
            txbAccountinfo.Text = "       Welcome " + atm.customer.Name + Environment.NewLine + Environment.NewLine + " Saving Account [" + atm.savingAccount.acNumber.ToString() + "]" + Environment.NewLine + " Current Balance: " + savbal.ToString();
            txbAmount.Focus();
        }
        public void DisplayAccount_c()
        {
            txbAccountinfo.Clear();
            decimal curbal = atm.currentAccount.acBalance;
            txbAccountinfo.Text = "       Welcome " + atm.customer.Name + Environment.NewLine + Environment.NewLine + " Current Account [" + atm.currentAccount.acNumber.ToString() + "]" + Environment.NewLine + " Current Balance: " + curbal.ToString();
            txbAmount.Focus();
        }
        private void btWithdrawal_Click_1(object sender, EventArgs e)
        {
            decimal curbal = atm.currentAccount.acBalance;
            decimal savbal = atm.savingAccount.acBalance;
            if (txbAmount.Text != null && txbAmount.Text != "")
            {
                if (rdbtFromSaving.Checked == true)
                {
                    s = dis_s();
                    decimal amount = Convert.ToDecimal(txbAmount.Text);
                    if (amount % 100 != 0 || amount > 20000)
                    {
                        txbAccountinfo.Clear();
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, the amount entered must be a multiple of 100,500 or 2000 Limited to maximum of RS 20000.00 for each transaction and upto maximum RS 25000.00 for each day";
                        riseNewtransaction();
                    }
                    else if (availabelATMmoney < amount)
                    {
                        txbAccountinfo.Clear();
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, there is not enough money available to progress this transaction ";
                        riseNewtransaction();
                    }
                    else if (savbal - amount < 0)
                    {
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, there is not enough balance to progress this transaction";
                        riseNewtransaction();
                        writeupdate();
                    }
                    else
                    {
                        decimal WithDrawSimulation = atm.currentAccount.acBalance - amount;
                        if (WithDrawSimulation >= 0 && s == 2)
                        {
                            atm.savingWithdraw(pin, amount);
                            availabelATMmoney -= amount;
                            cnt++;
                            dis_saving();
                            txbAccountinfo.Text = "Please Collect your Cash from Cash Drawer" + Environment.NewLine + "Cash Withdrawl of RS " + amount + " is Successful" + Environment.NewLine + "The Current Balance is: " + atm.savingAccount.acBalance.ToString();
                            riseNewtransaction();
                            atm.bank.acBalance = availabelATMmoney;
                            writeupdate();
                        }
                        else if (s == 0)
                        {
                            txbAccountinfo.Clear();
                            txbAccountinfo.Text = Environment.NewLine + "Sorry, you have reached your maximum limit of RS 25000 for today." + Environment.NewLine + "Try Again Tomorrow.";
                            riseNewtransaction();
                        }
                        else if (s == 1)
                        {
                            txbAccountinfo.Clear();
                            txbAccountinfo.Text = Environment.NewLine + "Sorry, you have reached your maximum limit for 4 transactions per day." + Environment.NewLine + "Try Again Tomorrow.";
                            riseNewtransaction();
                        }
                        else
                        {
                            txbAccountinfo.Text = "  There are no available funds in your account to progress this operation" + amount + Environment.NewLine + "the Current Balance is: " + atm.currentAccount.acBalance.ToString();
                            riseNewtransaction();
                        }
                    }
                }
                else if (rdbtFromCurrent.Checked == true)
                {
                    c = dis_c();
                    decimal amount = Convert.ToDecimal(txbAmount.Text);
                    if (amount % 100 != 0 || amount > 25000)
                    {
                        txbAccountinfo.Clear();
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, the amount entered must be a multiple of 100,500 or 2000 Limited to maximum of RS 25000.00 for each transaction and upto maximum RS 50000.00 for each day";
                        riseNewtransaction();
                    }
                    else if (availabelATMmoney < amount)
                    {
                        txbAccountinfo.Clear();
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, there is not enough money available to progress this transaction ";
                        riseNewtransaction();
                    }
                    else if (curbal - amount < 0)
                    {
                        txbAccountinfo.Text = Environment.NewLine + "Sorry, there is not enough balance to progress this transaction";
                        riseNewtransaction();
                        writeupdate();
                    }
                    else
                    {
                        decimal WithDrawSimulation = atm.currentAccount.acBalance - amount;
                        if (WithDrawSimulation >= 0 && c == 2)
                        {
                            atm.CurrentWithdraw(pin, amount);
                            availabelATMmoney -= amount;
                            cnt1++;
                            dis_current();
                            txbAccountinfo.Text = "Please Collect your Cash from Cash drawer" + Environment.NewLine + "Cash Withdrawl of RS " + amount + " is Successful" + Environment.NewLine + "The Current Balance is: " + atm.currentAccount.acBalance.ToString();
                            riseNewtransaction();
                            atm.bank.acBalance = availabelATMmoney;
                            writeupdate();
                        }
                        else if (c == 0)
                        {
                            txbAccountinfo.Clear();
                            txbAccountinfo.Text = Environment.NewLine + "Sorry, you have reached your maximum limit of RS 50000 for today." + Environment.NewLine + "Try Again Tomorrow.";
                            riseNewtransaction();
                        }
                        else if (c == 1)
                        {
                            txbAccountinfo.Clear();
                            txbAccountinfo.Text = Environment.NewLine + "Sorry, you have reached your maximum limit for 4 transactions per day." + Environment.NewLine + "Try Again Tomorrow.";
                            riseNewtransaction();
                        }
                        else
                        {
                            txbAccountinfo.Text = "  There are no available funds in your account to progress this operation" + amount + Environment.NewLine + "the Current Balance is: " + atm.currentAccount.acBalance.ToString();
                            riseNewtransaction();
                        }
                    }
                }
            }
            else
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                riseNewtransaction();
            }
        }
        public void riseNewtransaction()
        {
            btNewTransaction.Show();
            btWithdrawal.Hide();
            btCheckBalance.Hide();
            btMiniStatement.Hide();
            bgaccountSet.Hide();
            bgAmount.Hide();
            bgaccountSet.Enabled = false;
            bgAmount.Enabled = false;
            btNewTransaction.Focus();
            s = 3;
            c = 3;
        }
        private void btNewTransaction_Click_1(object sender, EventArgs e)
        {
            writeupdate();
            txbAmount.Clear();
            btNewTransaction.Show();
            btWithdrawal.Show();
            btCheckBalance.Show();
            btMiniStatement.Show();
            bgaccountSet.Show();
            bgAmount.Show();
            bgaccountSet.Enabled = true;
            bgAmount.Enabled = true;
            txbAmount.Focus();
            txbAccountinfo.Text = String.Empty;
        }
        private void btCloseApp_Click(object sender, EventArgs e)
        {
            txbAccountinfo.Clear();
            txbAmount.Clear();
            atm.bank.acBalance = availabelATMmoney;
            writeupdate();
            this.Close();
            mylog.Show();
        }
        private void txbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if ((char)e.KeyChar != '.' && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (e.KeyChar == '.' && this.txbAmount.Text.IndexOf('.') >= 0)
                e.Handled = true;
            int index = this.txbAmount.Text.IndexOf('.');
            if (index >= 0)
            {
                string Size = this.txbAmount.Text.Substring(index);
                if (Size.Length > 2 && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
        private void txbAmount_Click(object sender, EventArgs e)
        {
            txbAmount.SelectionStart = txbAmount.Text.Length + 1;
        }
        public void writeupdate()
        {
            atm.WriteAccount();
        }
        private void bttestwrite_Click(object sender, EventArgs e)
        {
            writeupdate();
        }
        public void validateAmount()
        {
            if (txbAmount.Text == null || txbAmount.Text == "")
            {
                txbAccountinfo.Clear();
                txbAccountinfo.Text = Environment.NewLine + "Please enter the amount in order to progress this transaction";
                riseNewtransaction();
            }
        }
        public int dis_s()
        {
            decimal amount = Convert.ToDecimal(txbAmount.Text);
            if (s == 3)
                amount1 += amount;
            if (s == 2)
                amount1 += amount;
            riseNewtransaction();
            if (amount1 > 25000)
            {
                if (s == 3)
                    amount1 -= amount;
                return 0;
            }
            else if (cnt > 3)
                return 1;
            else
            {
                if (s == 3)
                    amount1 -= amount;
                return 2;
            }
        }
        public int dis_c()
        {
            decimal amount = Convert.ToDecimal(txbAmount.Text);
            if (c == 3)
                amount2 += amount;
            if (c == 2)
                amount2 += amount;
            riseNewtransaction();
            if (amount2 > 50000)
            {
                if (c == 3)
                    amount2 -= amount;
                return 0;
            }
            else if (cnt1 > 3)
                return 1;
            else
            {
                if (c == 3)
                    amount2 -= amount;
                return 2;
            }
        }
        public void dis_saving()
        {
            decimal amount = Convert.ToDecimal(txbAmount.Text);
            amount1 += amount;
        }
        public void dis_current()
        {
            decimal amount = Convert.ToDecimal(txbAmount.Text);
            amount2 += amount;
        }
    }
}