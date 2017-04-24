namespace ProStats
{
    partial class FrmLecturerSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lecturerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lecturerId,
            this.lastName,
            this.firstName});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lecturerId
            // 
            this.lecturerId.HeaderText = "Lecturer Id";
            this.lecturerId.Name = "lecturerId";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "FirstName";
            this.firstName.Name = "firstName";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(209, 162);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Select";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmLecturerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 197);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmLecturerSearch";
            this.Text = "Lecturer Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnCancel;
    }
}