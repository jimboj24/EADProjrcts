namespace ProStats
{
    partial class FrmPhone
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboProvider = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provider";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(174, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(266, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "- Select --",
            "Home",
            "Mobile"});
            this.cboType.Location = new System.Drawing.Point(174, 127);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(184, 24);
            this.cboType.TabIndex = 4;
            // 
            // cboProvider
            // 
            this.cboProvider.FormattingEnabled = true;
            this.cboProvider.Items.AddRange(new object[] {
            "Flow",
            "Digicel"});
            this.cboProvider.Location = new System.Drawing.Point(174, 178);
            this.cboProvider.Name = "cboProvider";
            this.cboProvider.Size = new System.Drawing.Size(184, 24);
            this.cboProvider.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(354, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(-3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Add Phone Number";
            // 
            // FrmPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboProvider);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPhone";
            this.Text = "Add Phone Number";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboProvider;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}