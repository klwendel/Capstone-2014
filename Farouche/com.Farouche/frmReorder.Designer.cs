﻿namespace com.Farouche
{
    partial class frmReorder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbVendors = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.dgvReorder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReorder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnReorderChangeLevel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorder)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVendors
            // 
            this.cbVendors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendors.FormattingEnabled = true;
            this.cbVendors.Location = new System.Drawing.Point(12, 10);
            this.cbVendors.Name = "cbVendors";
            this.cbVendors.Size = new System.Drawing.Size(121, 21);
            this.cbVendors.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(139, 8);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dgvReorder
            // 
            this.dgvReorder.AllowUserToResizeColumns = false;
            this.dgvReorder.AllowUserToResizeRows = false;
            this.dgvReorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvReorder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvReorder.Location = new System.Drawing.Point(12, 37);
            this.dgvReorder.Name = "dgvReorder";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReorder.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvReorder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReorder.Size = new System.Drawing.Size(647, 263);
            this.dgvReorder.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "On Reorder";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column3.HeaderText = "Price Per Item";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Auto Reorder Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Reorder Amount";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // btnReorder
            // 
            this.btnReorder.Location = new System.Drawing.Point(584, 344);
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Size = new System.Drawing.Size(75, 23);
            this.btnReorder.TabIndex = 3;
            this.btnReorder.Text = "Reorder";
            this.btnReorder.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(487, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(571, 305);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(88, 22);
            this.txtTotalAmount.TabIndex = 6;
            this.txtTotalAmount.Text = "$0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReorderChangeLevel
            // 
            this.btnReorderChangeLevel.Location = new System.Drawing.Point(170, 335);
            this.btnReorderChangeLevel.Name = "btnReorderChangeLevel";
            this.btnReorderChangeLevel.Size = new System.Drawing.Size(131, 23);
            this.btnReorderChangeLevel.TabIndex = 7;
            this.btnReorderChangeLevel.Text = "Change Reorder Level";
            this.btnReorderChangeLevel.UseVisualStyleBackColor = true;
            this.btnReorderChangeLevel.Click += new System.EventHandler(this.btnReorderChangeLevel_Click);
            // 
            // frmReorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 379);
            this.Controls.Add(this.btnReorderChangeLevel);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReorder);
            this.Controls.Add(this.dgvReorder);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbVendors);
            this.Name = "frmReorder";
            this.Text = "frmReorder";
            this.Load += new System.EventHandler(this.frmReorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVendors;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView dgvReorder;
        private System.Windows.Forms.Button btnReorder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnReorderChangeLevel;
    }
}