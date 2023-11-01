namespace CertSerial
{
    partial class Backup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxselcttfolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btnbackup = new System.Windows.Forms.Button();
            this.lnlrestore = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxselcttfolder);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbxselcttfolder
            // 
            this.tbxselcttfolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxselcttfolder.Location = new System.Drawing.Point(192, 52);
            this.tbxselcttfolder.Name = "tbxselcttfolder";
            this.tbxselcttfolder.ReadOnly = true;
            this.tbxselcttfolder.Size = new System.Drawing.Size(386, 27);
            this.tbxselcttfolder.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnbackup
            // 
            this.Btnbackup.Location = new System.Drawing.Point(296, 226);
            this.Btnbackup.Name = "Btnbackup";
            this.Btnbackup.Size = new System.Drawing.Size(173, 47);
            this.Btnbackup.TabIndex = 1;
            this.Btnbackup.Text = "Back Up";
            this.Btnbackup.UseVisualStyleBackColor = true;
            this.Btnbackup.Click += new System.EventHandler(this.Btnbackup_Click);
            // 
            // lnlrestore
            // 
            this.lnlrestore.AutoSize = true;
            this.lnlrestore.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnlrestore.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnlrestore.Location = new System.Drawing.Point(582, 239);
            this.lnlrestore.Name = "lnlrestore";
            this.lnlrestore.Size = new System.Drawing.Size(59, 20);
            this.lnlrestore.TabIndex = 7;
            this.lnlrestore.TabStop = true;
            this.lnlrestore.Text = "Restore";
            this.lnlrestore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnlrestore_LinkClicked);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 326);
            this.Controls.Add(this.lnlrestore);
            this.Controls.Add(this.Btnbackup);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(787, 373);
            this.MinimumSize = new System.Drawing.Size(787, 373);
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbxselcttfolder;
        private Button button1;
        private Button Btnbackup;
        private LinkLabel lnlrestore;
    }
}