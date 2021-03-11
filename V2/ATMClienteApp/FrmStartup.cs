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
    public partial class FrmStartup : Form
    {
        public bool outofservice = false;
        int mode;
        public FrmStartup()
        {
            InitializeComponent();
        }
        private void FrmStartup_Load(object sender, EventArgs e)
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
        public void btLoginPin_Click(object sender, EventArgs e)
        {
            mode = 0;
            FrmLogin frmLogin = new FrmLogin(mode);
            this.Hide();
            frmLogin.Show();
            frmLogin.Activate();
        }

        private void btLoginFace_Click(object sender, EventArgs e)
        {
            mode = 1;
            FrmLogin frmLogin = new FrmLogin(mode);
            this.Hide();
            frmLogin.Show();
            frmLogin.Activate();
        }
    }
}