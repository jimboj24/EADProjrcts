﻿namespace ProStats
{
    partial class frmDepartmentSearch
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
            this.departmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCencel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentId,
            this.departmentName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // departmentId
            // 
            this.departmentId.HeaderText = "Department Id";
            this.departmentId.Name = "departmentId";
            // 
            // departmentName
            // 
            this.departmentName.HeaderText = "Department Name";
            this.departmentName.Name = "departmentName";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(230, 169);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(311, 169);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(75, 23);
            this.btnCencel.TabIndex = 2;
            this.btnCencel.Text = "Cencel";
            this.btnCencel.UseVisualStyleBackColor = true;
            // 
            // frmDepartmentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 204);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDepartmentSearch";
            this.Text = "frmDepartmentSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCencel;
    }
}