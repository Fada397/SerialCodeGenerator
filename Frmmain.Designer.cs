namespace CertSerial
{
    partial class Frmmain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxtraintype = new System.Windows.Forms.ComboBox();
            this.Dtmfrom = new System.Windows.Forms.DateTimePicker();
            this.DteTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrdSerial = new System.Windows.Forms.DataGridView();
            this.Clmdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkaddserial = new System.Windows.Forms.LinkLabel();
            this.lnkaddtraining = new System.Windows.Forms.LinkLabel();
            this.lnkdelete = new System.Windows.Forms.LinkLabel();
            this.blbexport = new System.Windows.Forms.LinkLabel();
            this.lnlbackup = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSerial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxtraintype
            // 
            this.cbxtraintype.FormattingEnabled = true;
            this.cbxtraintype.Location = new System.Drawing.Point(34, 70);
            this.cbxtraintype.Name = "cbxtraintype";
            this.cbxtraintype.Size = new System.Drawing.Size(414, 28);
            this.cbxtraintype.TabIndex = 0;
            // 
            // Dtmfrom
            // 
            this.Dtmfrom.Location = new System.Drawing.Point(519, 74);
            this.Dtmfrom.Name = "Dtmfrom";
            this.Dtmfrom.Size = new System.Drawing.Size(271, 27);
            this.Dtmfrom.TabIndex = 2;
            // 
            // DteTo
            // 
            this.DteTo.Location = new System.Drawing.Point(846, 74);
            this.DteTo.Name = "DteTo";
            this.DteTo.Size = new System.Drawing.Size(287, 27);
            this.DteTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Training Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(939, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date To";
            // 
            // GrdSerial
            // 
            this.GrdSerial.AllowUserToAddRows = false;
            this.GrdSerial.AllowUserToDeleteRows = false;
            this.GrdSerial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GrdSerial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdSerial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdSerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSerial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clmdescription,
            this.TrainingType,
            this.date1,
            this.serialNo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdSerial.DefaultCellStyle = dataGridViewCellStyle4;
            this.GrdSerial.Location = new System.Drawing.Point(34, 26);
            this.GrdSerial.Name = "GrdSerial";
            this.GrdSerial.ReadOnly = true;
            this.GrdSerial.RowHeadersWidth = 51;
            this.GrdSerial.RowTemplate.Height = 29;
            this.GrdSerial.Size = new System.Drawing.Size(1105, 374);
            this.GrdSerial.TabIndex = 7;
            // 
            // Clmdescription
            // 
            this.Clmdescription.DataPropertyName = "TraineeName";
            this.Clmdescription.HeaderText = "Trainee";
            this.Clmdescription.MinimumWidth = 6;
            this.Clmdescription.Name = "Clmdescription";
            this.Clmdescription.ReadOnly = true;
            this.Clmdescription.Width = 300;
            // 
            // TrainingType
            // 
            this.TrainingType.DataPropertyName = "TrainingType";
            this.TrainingType.HeaderText = "Training Type";
            this.TrainingType.MinimumWidth = 6;
            this.TrainingType.Name = "TrainingType";
            this.TrainingType.ReadOnly = true;
            this.TrainingType.Width = 300;
            // 
            // date1
            // 
            this.date1.DataPropertyName = "Trainingdate";
            this.date1.HeaderText = "Date";
            this.date1.MinimumWidth = 6;
            this.date1.Name = "date1";
            this.date1.ReadOnly = true;
            this.date1.Width = 200;
            // 
            // serialNo
            // 
            this.serialNo.DataPropertyName = "serialNo";
            this.serialNo.HeaderText = "Serial Number";
            this.serialNo.MinimumWidth = 6;
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            this.serialNo.Width = 250;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(474, 128);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(131, 49);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dtmfrom);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.cbxtraintype);
            this.groupBox1.Controls.Add(this.DteTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 188);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GrdSerial);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1176, 427);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lnkaddserial
            // 
            this.lnkaddserial.AutoSize = true;
            this.lnkaddserial.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkaddserial.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lnkaddserial.Location = new System.Drawing.Point(46, 675);
            this.lnkaddserial.Name = "lnkaddserial";
            this.lnkaddserial.Size = new System.Drawing.Size(144, 20);
            this.lnkaddserial.TabIndex = 11;
            this.lnkaddserial.TabStop = true;
            this.lnkaddserial.Text = "Generate New Serial";
            this.lnkaddserial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkaddserial_LinkClicked);
            // 
            // lnkaddtraining
            // 
            this.lnkaddtraining.AutoSize = true;
            this.lnkaddtraining.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkaddtraining.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lnkaddtraining.Location = new System.Drawing.Point(249, 675);
            this.lnkaddtraining.Name = "lnkaddtraining";
            this.lnkaddtraining.Size = new System.Drawing.Size(128, 20);
            this.lnkaddtraining.TabIndex = 12;
            this.lnkaddtraining.TabStop = true;
            this.lnkaddtraining.Text = "Add New Training";
            this.lnkaddtraining.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkaddtraining_LinkClicked);
            // 
            // lnkdelete
            // 
            this.lnkdelete.AutoSize = true;
            this.lnkdelete.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkdelete.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lnkdelete.Location = new System.Drawing.Point(725, 675);
            this.lnkdelete.Name = "lnkdelete";
            this.lnkdelete.Size = new System.Drawing.Size(94, 20);
            this.lnkdelete.TabIndex = 13;
            this.lnkdelete.TabStop = true;
            this.lnkdelete.Text = "Delete Serial";
            this.lnkdelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // blbexport
            // 
            this.blbexport.AutoSize = true;
            this.blbexport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.blbexport.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.blbexport.Location = new System.Drawing.Point(969, 675);
            this.blbexport.Name = "blbexport";
            this.blbexport.Size = new System.Drawing.Size(52, 20);
            this.blbexport.TabIndex = 14;
            this.blbexport.TabStop = true;
            this.blbexport.Text = "Export";
            this.blbexport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnlbackup
            // 
            this.lnlbackup.AutoSize = true;
            this.lnlbackup.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnlbackup.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lnlbackup.Location = new System.Drawing.Point(1093, 675);
            this.lnlbackup.Name = "lnlbackup";
            this.lnlbackup.Size = new System.Drawing.Size(57, 20);
            this.lnlbackup.TabIndex = 15;
            this.lnlbackup.TabStop = true;
            this.lnlbackup.Text = "Backup";
            this.lnlbackup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlbackup_LinkClicked);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 726);
            this.Controls.Add(this.lnlbackup);
            this.Controls.Add(this.blbexport);
            this.Controls.Add(this.lnkdelete);
            this.Controls.Add(this.lnkaddtraining);
            this.Controls.Add(this.lnkaddserial);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1218, 773);
            this.MinimumSize = new System.Drawing.Size(1218, 773);
            this.Name = "Frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CertSerial";
            this.Load += new System.EventHandler(this.Frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdSerial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxtraintype;
        private DateTimePicker Dtmfrom;
        private DateTimePicker DteTo;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView GrdSerial;
        private Button btnsearch;
        private DataGridViewTextBoxColumn Clmdescription;
        private DataGridViewTextBoxColumn TrainingType;
        private DataGridViewTextBoxColumn date1;
        private DataGridViewTextBoxColumn serialNo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private LinkLabel lnkaddserial;
        private LinkLabel lnkaddtraining;
        private LinkLabel lnkdelete;
        private LinkLabel blbexport;
        private LinkLabel lnlbackup;
    }
}