﻿namespace TombEditor.Forms
{
    partial class FormSprite
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
            this.butCancel = new DarkUI.Controls.DarkButton();
            this.butOk = new DarkUI.Controls.DarkButton();
            this.panelRenderingSprite = new WadTool.Controls.PanelRenderingSprite();
            this.cmbSprites = new DarkUI.Controls.DarkComboBox();
            this.butSearch = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.Checked = false;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(246, 301);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(80, 23);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Cancel";
            this.butCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOk
            // 
            this.butOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butOk.Checked = false;
            this.butOk.Location = new System.Drawing.Point(160, 301);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(80, 23);
            this.butOk.TabIndex = 1;
            this.butOk.Text = "OK";
            this.butOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // panelRenderingSprite
            // 
            this.panelRenderingSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRenderingSprite.Location = new System.Drawing.Point(8, 40);
            this.panelRenderingSprite.Name = "panelRenderingSprite";
            this.panelRenderingSprite.Size = new System.Drawing.Size(318, 255);
            this.panelRenderingSprite.SpriteID = 0;
            this.panelRenderingSprite.TabIndex = 9;
            // 
            // cmbSprites
            // 
            this.cmbSprites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSprites.FormattingEnabled = true;
            this.cmbSprites.Location = new System.Drawing.Point(8, 11);
            this.cmbSprites.Name = "cmbSprites";
            this.cmbSprites.Size = new System.Drawing.Size(296, 23);
            this.cmbSprites.TabIndex = 10;
            this.cmbSprites.SelectedIndexChanged += new System.EventHandler(this.cmbSprites_SelectedIndexChanged);
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.Checked = false;
            this.butSearch.Image = global::TombEditor.Properties.Resources.general_search_16;
            this.butSearch.Location = new System.Drawing.Point(303, 11);
            this.butSearch.Name = "butSearch";
            this.butSearch.Selectable = false;
            this.butSearch.Size = new System.Drawing.Size(23, 23);
            this.butSearch.TabIndex = 11;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // FormSprite
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(334, 332);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.cmbSprites);
            this.Controls.Add(this.panelRenderingSprite);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 370);
            this.Name = "FormSprite";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Edit sprite";
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton butCancel;
        private DarkUI.Controls.DarkButton butOk;
        private WadTool.Controls.PanelRenderingSprite panelRenderingSprite;
        private DarkUI.Controls.DarkComboBox cmbSprites;
        private DarkUI.Controls.DarkButton butSearch;
    }
}