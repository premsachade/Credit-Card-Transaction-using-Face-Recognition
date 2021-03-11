namespace ATMClienteApp
{
    partial class FrmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.txbadminInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btRefill = new System.Windows.Forms.Button();
            this.btTakeOutofService = new System.Windows.Forms.Button();
            this.btPrintRport = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.btDisplayReport = new System.Windows.Forms.Button();
            this.btTurnOff = new System.Windows.Forms.Button();
            this.btNewOp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsinfo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbadminInfo
            // 
            this.txbadminInfo.BackColor = System.Drawing.Color.DarkGray;
            this.txbadminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbadminInfo.Location = new System.Drawing.Point(13, 32);
            this.txbadminInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txbadminInfo.Multiline = true;
            this.txbadminInfo.Name = "txbadminInfo";
            this.txbadminInfo.ReadOnly = true;
            this.txbadminInfo.Size = new System.Drawing.Size(523, 336);
            this.txbadminInfo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(143, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "ATM Administrator";
            // 
            // btRefill
            // 
            this.btRefill.BackColor = System.Drawing.Color.DimGray;
            this.btRefill.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefill.Location = new System.Drawing.Point(544, 102);
            this.btRefill.Margin = new System.Windows.Forms.Padding(4);
            this.btRefill.Name = "btRefill";
            this.btRefill.Size = new System.Drawing.Size(227, 62);
            this.btRefill.TabIndex = 1;
            this.btRefill.Text = "Refill Money";
            this.btRefill.UseVisualStyleBackColor = false;
            this.btRefill.Click += new System.EventHandler(this.btRefill_Click);
            // 
            // btTakeOutofService
            // 
            this.btTakeOutofService.BackColor = System.Drawing.Color.DimGray;
            this.btTakeOutofService.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTakeOutofService.Location = new System.Drawing.Point(544, 172);
            this.btTakeOutofService.Margin = new System.Windows.Forms.Padding(4);
            this.btTakeOutofService.Name = "btTakeOutofService";
            this.btTakeOutofService.Size = new System.Drawing.Size(227, 62);
            this.btTakeOutofService.TabIndex = 2;
            this.btTakeOutofService.Text = "Out Of Service";
            this.btTakeOutofService.UseVisualStyleBackColor = false;
            this.btTakeOutofService.Click += new System.EventHandler(this.btTakeOutofService_Click);
            // 
            // btPrintRport
            // 
            this.btPrintRport.BackColor = System.Drawing.Color.DimGray;
            this.btPrintRport.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintRport.Location = new System.Drawing.Point(544, 242);
            this.btPrintRport.Margin = new System.Windows.Forms.Padding(4);
            this.btPrintRport.Name = "btPrintRport";
            this.btPrintRport.Size = new System.Drawing.Size(227, 62);
            this.btPrintRport.TabIndex = 3;
            this.btPrintRport.Text = "Print Report";
            this.btPrintRport.UseVisualStyleBackColor = false;
            this.btPrintRport.Click += new System.EventHandler(this.btPrintRport_Click);
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.DimGray;
            this.btQuit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuit.Location = new System.Drawing.Point(544, 452);
            this.btQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(227, 62);
            this.btQuit.TabIndex = 6;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btDisplayReport
            // 
            this.btDisplayReport.BackColor = System.Drawing.Color.DimGray;
            this.btDisplayReport.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayReport.Location = new System.Drawing.Point(544, 312);
            this.btDisplayReport.Margin = new System.Windows.Forms.Padding(4);
            this.btDisplayReport.Name = "btDisplayReport";
            this.btDisplayReport.Size = new System.Drawing.Size(227, 62);
            this.btDisplayReport.TabIndex = 4;
            this.btDisplayReport.Text = "Display Report";
            this.btDisplayReport.UseVisualStyleBackColor = false;
            this.btDisplayReport.Click += new System.EventHandler(this.btDisplayReport_Click);
            // 
            // btTurnOff
            // 
            this.btTurnOff.BackColor = System.Drawing.Color.DimGray;
            this.btTurnOff.Font = new System.Drawing.Font("Verdana", 13.25F);
            this.btTurnOff.Location = new System.Drawing.Point(544, 382);
            this.btTurnOff.Margin = new System.Windows.Forms.Padding(4);
            this.btTurnOff.Name = "btTurnOff";
            this.btTurnOff.Size = new System.Drawing.Size(227, 62);
            this.btTurnOff.TabIndex = 5;
            this.btTurnOff.Text = "Turn Off System";
            this.btTurnOff.UseVisualStyleBackColor = false;
            this.btTurnOff.Click += new System.EventHandler(this.btTurnOff_Click);
            // 
            // btNewOp
            // 
            this.btNewOp.BackColor = System.Drawing.Color.DimGray;
            this.btNewOp.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btNewOp.Location = new System.Drawing.Point(544, 32);
            this.btNewOp.Margin = new System.Windows.Forms.Padding(4);
            this.btNewOp.Name = "btNewOp";
            this.btNewOp.Size = new System.Drawing.Size(227, 62);
            this.btNewOp.TabIndex = 10;
            this.btNewOp.Text = "New Operation";
            this.btNewOp.UseVisualStyleBackColor = false;
            this.btNewOp.Click += new System.EventHandler(this.btNewOp_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tsinfo
            // 
            this.tsinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsinfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsinfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripLabel4});
            this.tsinfo.Location = new System.Drawing.Point(0, 528);
            this.tsinfo.Name = "tsinfo";
            this.tsinfo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsinfo.Size = new System.Drawing.Size(782, 25);
            this.tsinfo.TabIndex = 12;
            this.tsinfo.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel1.Text = "ATM V2.0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(183, 22);
            this.toolStripLabel2.Text = "Developer : Prem Sachade";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(319, 22);
            this.toolStripLabel3.Text = "Credit Card Transaction using Face Recognition";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(0, 22);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.tsinfo);
            this.Controls.Add(this.btNewOp);
            this.Controls.Add(this.btTurnOff);
            this.Controls.Add(this.btDisplayReport);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btPrintRport);
            this.Controls.Add(this.btTakeOutofService);
            this.Controls.Add(this.btRefill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbadminInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Machine Administrator";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.tsinfo.ResumeLayout(false);
            this.tsinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbadminInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRefill;
        private System.Windows.Forms.Button btTakeOutofService;
        private System.Windows.Forms.Button btPrintRport;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btDisplayReport;
        private System.Windows.Forms.Button btTurnOff;
        private System.Windows.Forms.Button btNewOp;
        private System.Windows.Forms.Timer timer1;
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