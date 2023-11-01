namespace CertSerial
{
    partial class FrmTraining
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Description = new System.Windows.Forms.Label();
            this.Tbxtraindescription = new System.Windows.Forms.TextBox();
            this.Tbxtraincode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddtraining = new System.Windows.Forms.Button();
            this.GrdTraining = new System.Windows.Forms.DataGridView();
            this.Clmdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkdelet = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTraining)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(6, 59);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(85, 20);
            this.Description.TabIndex = 0;
            this.Description.Text = "Description";
            // 
            // Tbxtraindescription
            // 
            this.Tbxtraindescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbxtraindescription.Location = new System.Drawing.Point(144, 52);
            this.Tbxtraindescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbxtraindescription.Name = "Tbxtraindescription";
            this.Tbxtraindescription.Size = new System.Drawing.Size(398, 34);
            this.Tbxtraindescription.TabIndex = 1;
            // 
            // Tbxtraincode
            // 
            this.Tbxtraincode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbxtraincode.Location = new System.Drawing.Point(144, 107);
            this.Tbxtraincode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbxtraincode.Name = "Tbxtraincode";
            this.Tbxtraincode.Size = new System.Drawing.Size(190, 34);
            this.Tbxtraincode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // btnaddtraining
            // 
            this.btnaddtraining.Location = new System.Drawing.Point(163, 243);
            this.btnaddtraining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaddtraining.Name = "btnaddtraining";
            this.btnaddtraining.Size = new System.Drawing.Size(171, 67);
            this.btnaddtraining.TabIndex = 4;
            this.btnaddtraining.Text = "Add Training";
            this.btnaddtraining.UseVisualStyleBackColor = true;
            this.btnaddtraining.Click += new System.EventHandler(this.btnaddtraining_Click);
            // 
            // GrdTraining
            // 
            this.GrdTraining.AllowUserToAddRows = false;
            this.GrdTraining.AllowUserToDeleteRows = false;
            this.GrdTraining.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GrdTraining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdTraining.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdTraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clmdescription,
            this.Clmcode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdTraining.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdTraining.Location = new System.Drawing.Point(15, 56);
            this.GrdTraining.Name = "GrdTraining";
            this.GrdTraining.ReadOnly = true;
            this.GrdTraining.RowHeadersWidth = 51;
            this.GrdTraining.RowTemplate.Height = 29;
            this.GrdTraining.Size = new System.Drawing.Size(484, 320);
            this.GrdTraining.TabIndex = 5;
            this.GrdTraining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdTraining_CellContentClick);
            // 
            // Clmdescription
            // 
            this.Clmdescription.DataPropertyName = "Description";
            this.Clmdescription.HeaderText = "Description";
            this.Clmdescription.MinimumWidth = 6;
            this.Clmdescription.Name = "Clmdescription";
            this.Clmdescription.ReadOnly = true;
            this.Clmdescription.Width = 300;
            // 
            // Clmcode
            // 
            this.Clmcode.DataPropertyName = "Code";
            this.Clmcode.HeaderText = "Code";
            this.Clmcode.MinimumWidth = 6;
            this.Clmcode.Name = "Clmcode";
            this.Clmcode.ReadOnly = true;
            this.Clmcode.Width = 130;
            // 
            // lnkdelet
            // 
            this.lnkdelet.AutoSize = true;
            this.lnkdelet.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkdelet.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkdelet.Location = new System.Drawing.Point(15, 393);
            this.lnkdelet.Name = "lnkdelet";
            this.lnkdelet.Size = new System.Drawing.Size(53, 20);
            this.lnkdelet.TabIndex = 6;
            this.lnkdelet.TabStop = true;
            this.lnkdelet.Text = "Delete";
            this.lnkdelet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkdelet);
            this.groupBox1.Controls.Add(this.GrdTraining);
            this.groupBox1.Location = new System.Drawing.Point(585, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 428);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Training";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnaddtraining);
            this.groupBox2.Controls.Add(this.Tbxtraindescription);
            this.groupBox2.Controls.Add(this.Tbxtraincode);
            this.groupBox2.Controls.Add(this.Description);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 428);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Training";
            // 
            // FrmTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1120, 505);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1120, 505);
            this.Name = "FrmTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training";
            ((System.ComponentModel.ISupportInitialize)(this.GrdTraining)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Description;
        private TextBox Tbxtraindescription;
        private TextBox Tbxtraincode;
        private Label label2;
        private Button btnaddtraining;
        private DataGridView GrdTraining;
        private LinkLabel lnkdelet;
        private DataGridViewTextBoxColumn Clmdescription;
        private DataGridViewTextBoxColumn Clmcode;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}