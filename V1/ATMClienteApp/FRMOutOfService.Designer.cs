namespace ATMClienteApp
{
    partial class FRMOutOfService
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
            this.txbinfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSecret = new System.Windows.Forms.Button();
            this.txadmname = new System.Windows.Forms.TextBox();
            this.txbadmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btBackToWork = new System.Windows.Forms.Button();
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
            // txbinfo
            // 
            this.txbinfo.BackColor = System.Drawing.Color.DimGray;
            this.txbinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbinfo.ForeColor = System.Drawing.Color.Maroon;
            this.txbinfo.Location = new System.Drawing.Point(128, 95);
            this.txbinfo.Margin = new System.Windows.Forms.Padding(4);
            this.txbinfo.Multiline = true;
            this.txbinfo.Name = "txbinfo";
            this.txbinfo.ReadOnly = true;
            this.txbinfo.Size = new System.Drawing.Size(548, 159);
            this.txbinfo.TabIndex = 3;
            this.txbinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "Welcome to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bank of Baroda ATM";
            // 
            // btSecret
            // 
            this.btSecret.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSecret.Location = new System.Drawing.Point(669, 414);
            this.btSecret.Margin = new System.Windows.Forms.Padding(4);
            this.btSecret.Name = "btSecret";
            this.btSecret.Size = new System.Drawing.Size(100, 85);
            this.btSecret.TabIndex = 2;
            this.btSecret.Text = "ADM";
            this.btSecret.UseVisualStyleBackColor = false;
            this.btSecret.Click += new System.EventHandler(this.btSecret_Click);
            // 
            // txadmname
            // 
            this.txadmname.BackColor = System.Drawing.Color.Silver;
            this.txadmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txadmname.Location = new System.Drawing.Point(181, 306);
            this.txadmname.Margin = new System.Windows.Forms.Padding(4);
            this.txadmname.Name = "txadmname";
            this.txadmname.Size = new System.Drawing.Size(441, 30);
            this.txadmname.TabIndex = 0;
            this.txadmname.Visible = false;
            // 
            // txbadmPass
            // 
            this.txbadmPass.BackColor = System.Drawing.Color.Silver;
            this.txbadmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbadmPass.Location = new System.Drawing.Point(181, 396);
            this.txbadmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbadmPass.Name = "txbadmPass";
            this.txbadmPass.PasswordChar = '*';
            this.txbadmPass.Size = new System.Drawing.Size(441, 30);
            this.txbadmPass.TabIndex = 1;
            this.txbadmPass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrator Only";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(177, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btBackToWork
            // 
            this.btBackToWork.BackColor = System.Drawing.Color.Green;
            this.btBackToWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btBackToWork.Location = new System.Drawing.Point(183, 447);
            this.btBackToWork.Margin = new System.Windows.Forms.Padding(4);
            this.btBackToWork.Name = "btBackToWork";
            this.btBackToWork.Size = new System.Drawing.Size(441, 52);
            this.btBackToWork.TabIndex = 7;
            this.btBackToWork.Text = "Reactivate System";
            this.btBackToWork.UseVisualStyleBackColor = false;
            this.btBackToWork.Visible = false;
            this.btBackToWork.Click += new System.EventHandler(this.btBackToWork_Click);
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
            this.tsinfo.TabIndex = 8;
            this.tsinfo.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel1.Text = "ATM V1.0";
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
            // FRMOutOfService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.tsinfo);
            this.Controls.Add(this.btBackToWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbadmPass);
            this.Controls.Add(this.txadmname);
            this.Controls.Add(this.btSecret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMOutOfService";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorry We are Out of Service";
            this.Load += new System.EventHandler(this.FRMOutOfService_Load);
            this.tsinfo.ResumeLayout(false);
            this.tsinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbinfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSecret;
        private System.Windows.Forms.TextBox txadmname;
        private System.Windows.Forms.TextBox txbadmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btBackToWork;
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