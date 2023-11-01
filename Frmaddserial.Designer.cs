namespace CertSerial
{
    partial class Frmaddserial
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtmTraindate = new System.Windows.Forms.DateTimePicker();
            this.Cbxtraintype = new System.Windows.Forms.ComboBox();
            this.TbxtraineeName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxinitial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(310, 351);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(149, 53);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Training Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Training Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name of Trainee";
            // 
            // DtmTraindate
            // 
            this.DtmTraindate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtmTraindate.Location = new System.Drawing.Point(213, 244);
            this.DtmTraindate.Name = "DtmTraindate";
            this.DtmTraindate.Size = new System.Drawing.Size(333, 34);
            this.DtmTraindate.TabIndex = 9;
            // 
            // Cbxtraintype
            // 
            this.Cbxtraintype.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Cbxtraintype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbxtraintype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cbxtraintype.FormattingEnabled = true;
            this.Cbxtraintype.Location = new System.Drawing.Point(213, 119);
            this.Cbxtraintype.Name = "Cbxtraintype";
            this.Cbxtraintype.Size = new System.Drawing.Size(417, 36);
            this.Cbxtraintype.TabIndex = 8;
            // 
            // TbxtraineeName
            // 
            this.TbxtraineeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbxtraineeName.Location = new System.Drawing.Point(210, 56);
            this.TbxtraineeName.Name = "TbxtraineeName";
            this.TbxtraineeName.Size = new System.Drawing.Size(420, 34);
            this.TbxtraineeName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxinitial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cbxtraintype);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.TbxtraineeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtmTraindate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 436);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Serial Number";
            // 
            // tbxinitial
            // 
            this.tbxinitial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxinitial.Location = new System.Drawing.Point(210, 182);
            this.tbxinitial.Name = "tbxinitial";
            this.tbxinitial.Size = new System.Drawing.Size(304, 34);
            this.tbxinitial.TabIndex = 14;
            this.tbxinitial.Text = "AGGL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Company Initial";
            // 
            // Frmaddserial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 460);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(821, 507);
            this.MinimumSize = new System.Drawing.Size(821, 507);
            this.Name = "Frmaddserial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CertSerial";
            this.Load += new System.EventHandler(this.Frmaddserial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSave;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker DtmTraindate;
        private ComboBox Cbxtraintype;
        private TextBox TbxtraineeName;
        private GroupBox groupBox1;
        private TextBox tbxinitial;
        private Label label4;
    }
}