﻿namespace AqT_Utl
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infomationLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AqT_Utl.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infomationLabel
            // 
            this.infomationLabel.AutoSize = true;
            this.infomationLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.infomationLabel.Location = new System.Drawing.Point(11, 159);
            this.infomationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infomationLabel.Name = "infomationLabel";
            this.infomationLabel.Size = new System.Drawing.Size(125, 12);
            this.infomationLabel.TabIndex = 1;
            this.infomationLabel.Text = "Copyright ちびすけ 2023";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(11, 194);
            this.GitHubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(209, 15);
            this.GitHubLabel.TabIndex = 2;
            this.GitHubLabel.TabStop = true;
            this.GitHubLabel.Text = "github.com/ChibiBouningen/AqtUtl";
            this.GitHubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLabel_LinkClicked);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 241);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.infomationLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AqtUtlについて";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infomationLabel;
        private System.Windows.Forms.LinkLabel GitHubLabel;
    }
}