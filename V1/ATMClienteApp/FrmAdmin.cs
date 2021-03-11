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

namespace ATMClienteApp
{
    public partial class FrmAdmin : Form
    {
        string pin;
        FrmStartup mylog;
        atmManager atm = new atmManager();
        decimal availabelATMmoney;
        string nnline = Environment.NewLine + Environment.NewLine;
        string today = DateTime.Now.ToShortDateString();
        public FrmAdmin(string PIN, FrmStartup MYLOG, atmManager ATM)
        {
            InitializeComponent();
            pin = PIN;
            mylog = MYLOG;
            atm = ATM;
        }
        private void DisplayAtm()
        {
            txbadminInfo.Clear();
            txbadminInfo.Text = Environment.NewLine + "Welcome to ATM Administrator System" + nnline + "The Current Balance at " + today + " is : RS " + atm.bank.acBalance.ToString();
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            availabelATMmoney = atm.bank.acBalance;
            DisplayAtm();
            btNewOp.Show();
        }
        public void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            mylog.Show();
            WriteUpdateAcount();
        }
        public void risenewoperation()
        {
            btDisplayReport.Hide();
            btPrintRport.Hide();
            btRefill.Hide();
            btTakeOutofService.Hide();
            btTurnOff.Hide();
            btNewOp.Show();
        }
        private void btNewOp_Click(object sender, EventArgs e)
        {
            DisplayAtm();
            btDisplayReport.Show();
            btPrintRport.Show();
            btRefill.Show();
            btTakeOutofService.Show();
            btTurnOff.Show();
            btNewOp.Show();
        }
        public void WriteUpdateAcount()
        {
            atm.WriteAccount();
        }
        private void btRefill_Click(object sender, EventArgs e)
        {
            atm.bank.refillATM();
            txbadminInfo.Clear();
            txbadminInfo.Text = nnline + "   Refill successfully progressed!" + nnline + "  The current available balance on the ATM is : " + nnline + "  RS " + atm.bank.acBalance + nnline + "  Thank you for Using ATM Simulator";
            risenewoperation();
            WriteUpdateAcount();
        }
        private void btTurnOff_Click(object sender, EventArgs e)
        {
            txbadminInfo.Clear();
            txbadminInfo.Text = nnline + "  The System is Running the Safety turn off, do not power off or unplug your machine!" + nnline + nnline + "  Thank you for Using ATM Simulator";
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txbadminInfo.Clear();
            Application.Exit();
        }
        private void btPrintRport_Click(object sender, EventArgs e)
        {
            txbadminInfo.Clear();
            txbadminInfo.Text = nnline + "   Sorry this Function Is Temporarily out of Service";
            risenewoperation();
        }
        private void btDisplayReport_Click(object sender, EventArgs e)
        {
            txbadminInfo.Clear();
            txbadminInfo.Text = nnline + "   Sorry this Function Is Temporarily out of Service";
            risenewoperation();
        }
        private void btTakeOutofService_Click(object sender, EventArgs e)
        {
            FRMOutOfService outofservice = new FRMOutOfService(atm, mylog);
            outofservice.Show();
            outofservice.Show();
        }
    }
}