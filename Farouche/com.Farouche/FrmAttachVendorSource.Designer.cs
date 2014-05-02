﻿namespace com.Farouche
{
    partial class FrmAttachVendorSource
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCaseQty = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.nudUnitPrice = new com.Farouche.Commons.CurrencyUpDown();
            this.cbActive = new System.Windows.Forms.ComboBox();
            this.cbVendor = new System.Windows.Forms.ComboBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.nudCase = new System.Windows.Forms.NumericUpDown();
            this.nudMinnimum = new System.Windows.Forms.NumericUpDown();
            this.lblDisplayUnitPrice = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinnimum)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(56, 189);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 45;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(137, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add Vendor";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(35, 22);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(58, 13);
            this.lblVendor.TabIndex = 0;
            this.lblVendor.Text = "Vendor ID:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(37, 75);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 0;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblCaseQty
            // 
            this.lblCaseQty.AutoSize = true;
            this.lblCaseQty.Location = new System.Drawing.Point(17, 126);
            this.lblCaseQty.Name = "lblCaseQty";
            this.lblCaseQty.Size = new System.Drawing.Size(76, 13);
            this.lblCaseQty.TabIndex = 0;
            this.lblCaseQty.Text = "Case Quantity:";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(53, 153);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(40, 13);
            this.lblActive.TabIndex = 0;
            this.lblActive.Text = "Active:";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.DecimalPlaces = 2;
            this.nudUnitPrice.Location = new System.Drawing.Point(99, 72);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.nudUnitPrice.TabIndex = 41;
            this.nudUnitPrice.ValueChanged += new System.EventHandler(this.nudUnitPrice_ValueChanged);
            this.nudUnitPrice.Enter += new System.EventHandler(this.nudUnitPrice_Enter);
            // 
            // cbActive
            // 
            this.cbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActive.FormattingEnabled = true;
            this.cbActive.Location = new System.Drawing.Point(99, 150);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(121, 21);
            this.cbActive.TabIndex = 44;
            // 
            // cbVendor
            // 
            this.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendor.FormattingEnabled = true;
            this.cbVendor.Location = new System.Drawing.Point(99, 19);
            this.cbVendor.Name = "cbVendor";
            this.cbVendor.Size = new System.Drawing.Size(121, 21);
            this.cbVendor.TabIndex = 40;
            this.cbVendor.SelectedIndexChanged += new System.EventHandler(this.cbVendor_SelectedIndexChanged);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(13, 100);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(80, 13);
            this.lblMinimum.TabIndex = 0;
            this.lblMinimum.Text = "Minimum Order:";
            // 
            // nudCase
            // 
            this.nudCase.Location = new System.Drawing.Point(99, 124);
            this.nudCase.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCase.Name = "nudCase";
            this.nudCase.Size = new System.Drawing.Size(121, 20);
            this.nudCase.TabIndex = 43;
            this.nudCase.Enter += new System.EventHandler(this.nudUnitPrice_Enter);
            // 
            // nudMinnimum
            // 
            this.nudMinnimum.Location = new System.Drawing.Point(99, 98);
            this.nudMinnimum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMinnimum.Name = "nudMinnimum";
            this.nudMinnimum.Size = new System.Drawing.Size(121, 20);
            this.nudMinnimum.TabIndex = 42;
            this.nudMinnimum.Enter += new System.EventHandler(this.nudUnitPrice_Enter);
            // 
            // lblDisplayUnitPrice
            // 
            this.lblDisplayUnitPrice.AutoSize = true;
            this.lblDisplayUnitPrice.Location = new System.Drawing.Point(218, 75);
            this.lblDisplayUnitPrice.Name = "lblDisplayUnitPrice";
            this.lblDisplayUnitPrice.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayUnitPrice.TabIndex = 51;
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(18, 49);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblVendorName.TabIndex = 0;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Enabled = false;
            this.txtVendorName.Location = new System.Drawing.Point(99, 46);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(121, 20);
            this.txtVendorName.TabIndex = 0;
            // 
            // FrmAttachVendorSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 253);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblDisplayUnitPrice);
            this.Controls.Add(this.nudCase);
            this.Controls.Add(this.nudMinnimum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.cbVendor);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblCaseQty);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btCancel);
            this.Name = "FrmAttachVendorSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attach Vendor";
            this.Load += new System.EventHandler(this.FrmAttachVendorSource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinnimum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCaseQty;
        private System.Windows.Forms.Label lblActive;
        private com.Farouche.Commons.CurrencyUpDown nudUnitPrice;
        private System.Windows.Forms.ComboBox cbActive;
        private System.Windows.Forms.ComboBox cbVendor;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.NumericUpDown nudCase;
        private System.Windows.Forms.NumericUpDown nudMinnimum;
        private System.Windows.Forms.Label lblDisplayUnitPrice;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.TextBox txtVendorName;
    }
}