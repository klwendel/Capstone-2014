﻿namespace com.Farouche
{
    partial class FrmShippingAllOrders
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
            this.btnClearUser = new System.Windows.Forms.Button();
            this.lvAllOrders = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnClearUser
            // 
            this.btnClearUser.Location = new System.Drawing.Point(383, 252);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(144, 23);
            this.btnClearUser.TabIndex = 3;
            this.btnClearUser.Text = "Clear User";
            this.btnClearUser.UseVisualStyleBackColor = true;
            this.btnClearUser.Click += new System.EventHandler(this.btnClearUser_Click);
            // 
            // lvAllOrders
            // 
            this.lvAllOrders.FullRowSelect = true;
            this.lvAllOrders.GridLines = true;
            this.lvAllOrders.HideSelection = false;
            this.lvAllOrders.Location = new System.Drawing.Point(2, 0);
            this.lvAllOrders.MultiSelect = false;
            this.lvAllOrders.Name = "lvAllOrders";
            this.lvAllOrders.Size = new System.Drawing.Size(760, 252);
            this.lvAllOrders.TabIndex = 0;
            this.lvAllOrders.UseCompatibleStateImageBehavior = false;
            this.lvAllOrders.View = System.Windows.Forms.View.Details;
            // 
            // FrmShippingAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 281);
            this.Controls.Add(this.btnClearUser);
            this.Controls.Add(this.lvAllOrders);
            this.Name = "FrmShippingAllOrders";
            this.Text = "frmShippingAllOrders";
            this.Load += new System.EventHandler(this.FrmShippingAllOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.ListView lvAllOrders;
    }
}