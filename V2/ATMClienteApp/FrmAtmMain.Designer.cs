namespace ATMClienteApp
{
    partial class FrmAtmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtmMain));
            this.btWithdrawal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAccountinfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCloseApp = new System.Windows.Forms.Button();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.rdbtFromCurrent = new System.Windows.Forms.RadioButton();
            this.rdbtFromSaving = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bgaccountSet = new System.Windows.Forms.GroupBox();
            this.bgAmount = new System.Windows.Forms.GroupBox();
            this.btNewTransaction = new System.Windows.Forms.Button();
            this.btCheckBalance = new System.Windows.Forms.Button();
            this.btMiniStatement = new System.Windows.Forms.Button();
            this.tsinfo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.bgaccountSet.SuspendLayout();
            this.bgAmount.SuspendLayout();
            this.tsinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btWithdrawal
            // 
            this.btWithdrawal.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btWithdrawal, "btWithdrawal");
            this.btWithdrawal.Name = "btWithdrawal";
            this.btWithdrawal.UseVisualStyleBackColor = false;
            this.btWithdrawal.Click += new System.EventHandler(this.btWithdrawal_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txbAccountinfo
            // 
            this.txbAccountinfo.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txbAccountinfo, "txbAccountinfo");
            this.txbAccountinfo.Name = "txbAccountinfo";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btCloseApp
            // 
            this.btCloseApp.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btCloseApp, "btCloseApp");
            this.btCloseApp.Name = "btCloseApp";
            this.btCloseApp.UseVisualStyleBackColor = false;
            this.btCloseApp.Click += new System.EventHandler(this.btCloseApp_Click);
            // 
            // txbAmount
            // 
            this.txbAmount.BackColor = System.Drawing.Color.Silver;
            this.txbAmount.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txbAmount, "txbAmount");
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Click += new System.EventHandler(this.txbAmount_Click);
            this.txbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAmount_KeyPress);
            // 
            // rdbtFromCurrent
            // 
            resources.ApplyResources(this.rdbtFromCurrent, "rdbtFromCurrent");
            this.rdbtFromCurrent.Name = "rdbtFromCurrent";
            this.rdbtFromCurrent.TabStop = true;
            this.rdbtFromCurrent.UseVisualStyleBackColor = true;
            // 
            // rdbtFromSaving
            // 
            resources.ApplyResources(this.rdbtFromSaving, "rdbtFromSaving");
            this.rdbtFromSaving.Name = "rdbtFromSaving";
            this.rdbtFromSaving.TabStop = true;
            this.rdbtFromSaving.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // bgaccountSet
            // 
            this.bgaccountSet.Controls.Add(this.rdbtFromSaving);
            this.bgaccountSet.Controls.Add(this.rdbtFromCurrent);
            resources.ApplyResources(this.bgaccountSet, "bgaccountSet");
            this.bgaccountSet.Name = "bgaccountSet";
            this.bgaccountSet.TabStop = false;
            // 
            // bgAmount
            // 
            this.bgAmount.Controls.Add(this.label3);
            this.bgAmount.Controls.Add(this.txbAmount);
            resources.ApplyResources(this.bgAmount, "bgAmount");
            this.bgAmount.Name = "bgAmount";
            this.bgAmount.TabStop = false;
            // 
            // btNewTransaction
            // 
            this.btNewTransaction.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btNewTransaction, "btNewTransaction");
            this.btNewTransaction.Name = "btNewTransaction";
            this.btNewTransaction.UseVisualStyleBackColor = false;
            this.btNewTransaction.Click += new System.EventHandler(this.btNewTransaction_Click_1);
            // 
            // btCheckBalance
            // 
            this.btCheckBalance.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btCheckBalance, "btCheckBalance");
            this.btCheckBalance.Name = "btCheckBalance";
            this.btCheckBalance.UseVisualStyleBackColor = false;
            this.btCheckBalance.Click += new System.EventHandler(this.btCheckBalance_Click);
            // 
            // btMiniStatement
            // 
            this.btMiniStatement.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btMiniStatement, "btMiniStatement");
            this.btMiniStatement.Name = "btMiniStatement";
            this.btMiniStatement.UseVisualStyleBackColor = false;
            this.btMiniStatement.Click += new System.EventHandler(this.btMiniStatement_Click);
            // 
            // tsinfo
            // 
            resources.ApplyResources(this.tsinfo, "tsinfo");
            this.tsinfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsinfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripLabel4});
            this.tsinfo.Name = "tsinfo";
            this.tsinfo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel3.Name = "toolStripLabel3";
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel4.Name = "toolStripLabel4";
            resources.ApplyResources(this.toolStripLabel4, "toolStripLabel4");
            // 
            // FrmAtmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ControlBox = false;
            this.Controls.Add(this.tsinfo);
            this.Controls.Add(this.btMiniStatement);
            this.Controls.Add(this.btCheckBalance);
            this.Controls.Add(this.btNewTransaction);
            this.Controls.Add(this.bgAmount);
            this.Controls.Add(this.bgaccountSet);
            this.Controls.Add(this.btCloseApp);
            this.Controls.Add(this.txbAccountinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWithdrawal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAtmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FrmAtmMain_Load);
            this.bgaccountSet.ResumeLayout(false);
            this.bgaccountSet.PerformLayout();
            this.bgAmount.ResumeLayout(false);
            this.bgAmount.PerformLayout();
            this.tsinfo.ResumeLayout(false);
            this.tsinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWithdrawal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAccountinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCloseApp;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.RadioButton rdbtFromCurrent;
        private System.Windows.Forms.RadioButton rdbtFromSaving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox bgaccountSet;
        private System.Windows.Forms.GroupBox bgAmount;
        private System.Windows.Forms.Button btNewTransaction;
        private System.Windows.Forms.Button btCheckBalance;
        private System.Windows.Forms.Button btMiniStatement;
        private System.Windows.Forms.ToolStrip tsinfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}