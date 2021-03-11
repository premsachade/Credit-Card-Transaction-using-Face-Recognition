namespace ATMClienteApp
{
    partial class FrmLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPin = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsinfo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txbtime = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbsorry = new System.Windows.Forms.Label();
            this.lboutofService = new System.Windows.Forms.Label();
            this.btAddFace = new System.Windows.Forms.Button();
            this.tsinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(112, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(112, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bank of Baroda ATM ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Welcome to";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.Silver;
            this.txbName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(112, 197);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(353, 36);
            this.txbName.TabIndex = 1;
            // 
            // txbPin
            // 
            this.txbPin.BackColor = System.Drawing.Color.Silver;
            this.txbPin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPin.Location = new System.Drawing.Point(112, 297);
            this.txbPin.Name = "txbPin";
            this.txbPin.PasswordChar = '*';
            this.txbPin.Size = new System.Drawing.Size(353, 36);
            this.txbPin.TabIndex = 2;
            this.txbPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPin_KeyDown);
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
            this.tsinfo.TabIndex = 3;
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
            // txbtime
            // 
            this.txbtime.BackColor = System.Drawing.Color.Gray;
            this.txbtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbtime.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbtime.Location = new System.Drawing.Point(473, 390);
            this.txbtime.Name = "txbtime";
            this.txbtime.Size = new System.Drawing.Size(288, 28);
            this.txbtime.TabIndex = 4;
            this.txbtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.DimGray;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btLogin.Location = new System.Drawing.Point(530, 150);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(230, 50);
            this.btLogin.TabIndex = 5;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            this.btLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btLogin_KeyDown);
            // 
            // lbsorry
            // 
            this.lbsorry.AutoSize = true;
            this.lbsorry.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsorry.ForeColor = System.Drawing.Color.Gray;
            this.lbsorry.Location = new System.Drawing.Point(222, 420);
            this.lbsorry.Name = "lbsorry";
            this.lbsorry.Size = new System.Drawing.Size(339, 29);
            this.lbsorry.TabIndex = 6;
            this.lbsorry.Text = "sorry for the inconvenience";
            // 
            // lboutofService
            // 
            this.lboutofService.AutoSize = true;
            this.lboutofService.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboutofService.ForeColor = System.Drawing.Color.Gray;
            this.lboutofService.Location = new System.Drawing.Point(222, 357);
            this.lboutofService.Name = "lboutofService";
            this.lboutofService.Size = new System.Drawing.Size(329, 29);
            this.lboutofService.TabIndex = 6;
            this.lboutofService.Text = "Temporarily out Of Service";
            // 
            // btAddFace
            // 
            this.btAddFace.BackColor = System.Drawing.Color.DimGray;
            this.btAddFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddFace.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btAddFace.Location = new System.Drawing.Point(530, 250);
            this.btAddFace.Name = "btAddFace";
            this.btAddFace.Size = new System.Drawing.Size(230, 50);
            this.btAddFace.TabIndex = 7;
            this.btAddFace.Text = "Add Face Data";
            this.btAddFace.UseVisualStyleBackColor = false;
            this.btAddFace.Click += new System.EventHandler(this.btAddFace_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btAddFace);
            this.Controls.Add(this.lbsorry);
            this.Controls.Add(this.lboutofService);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txbtime);
            this.Controls.Add(this.tsinfo);
            this.Controls.Add(this.txbPin);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "ATM Machine";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.tsinfo.ResumeLayout(false);
            this.tsinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip tsinfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txbtime;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbsorry;
        private System.Windows.Forms.Label lboutofService;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Button btAddFace;
    }
}

