﻿namespace com.Farouche
{
    partial class FrmShippingPackList
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
            this.btnPackComplete = new System.Windows.Forms.Button();
            this.lvPackList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnPackComplete
            // 
            this.btnPackComplete.Location = new System.Drawing.Point(615, 270);
            this.btnPackComplete.Name = "btnPackComplete";
            this.btnPackComplete.Size = new System.Drawing.Size(144, 23);
            this.btnPackComplete.TabIndex = 3;
            this.btnPackComplete.Text = "Ready for Ship";
            this.btnPackComplete.UseVisualStyleBackColor = true;
            this.btnPackComplete.Click += new System.EventHandler(this.btnPackComplete_Click);
            // 
            // lvPackList
            // 
            this.lvPackList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPackList.FullRowSelect = true;
            this.lvPackList.GridLines = true;
            this.lvPackList.HideSelection = false;
            this.lvPackList.Location = new System.Drawing.Point(12, 12);
            this.lvPackList.MultiSelect = false;
            this.lvPackList.Name = "lvPackList";
            this.lvPackList.Size = new System.Drawing.Size(747, 252);
            this.lvPackList.TabIndex = 2;
            this.lvPackList.UseCompatibleStateImageBehavior = false;
            this.lvPackList.View = System.Windows.Forms.View.Details;
            this.lvPackList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvPackList_ColumnClick);
            this.lvPackList.SelectedIndexChanged += new System.EventHandler(this.lvPackList_SelectedIndexChanged);
            // 
            // FrmShippingPackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 347);
            this.Controls.Add(this.btnPackComplete);
            this.Controls.Add(this.lvPackList);
            this.Name = "FrmShippingPackList";
            this.Text = "Pack List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmShippingPackList_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPackComplete;
        private System.Windows.Forms.ListView lvPackList;
    }
}