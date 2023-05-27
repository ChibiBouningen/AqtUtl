namespace AqT_Utl
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProfileSelectSprit = new System.Windows.Forms.SplitContainer();
            this.ProfileListBox = new System.Windows.Forms.ListBox();
            this.SettingButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TextBoxSprit = new System.Windows.Forms.SplitContainer();
            this.JimakuSprit = new System.Windows.Forms.SplitContainer();
            this.JimakuLabel = new System.Windows.Forms.Label();
            this.JimakuBox = new System.Windows.Forms.TextBox();
            this.HatsuonSprit = new System.Windows.Forms.SplitContainer();
            this.JimakuCopy_Check = new System.Windows.Forms.CheckBox();
            this.HatsuonLabel = new System.Windows.Forms.Label();
            this.HatsuonBox = new System.Windows.Forms.TextBox();
            this.GeneratePanel = new System.Windows.Forms.Panel();
            this.ProfileListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.プロファイルを追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロファイルを編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロファイルを削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileSelectSprit)).BeginInit();
            this.ProfileSelectSprit.Panel1.SuspendLayout();
            this.ProfileSelectSprit.Panel2.SuspendLayout();
            this.ProfileSelectSprit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSprit)).BeginInit();
            this.TextBoxSprit.Panel1.SuspendLayout();
            this.TextBoxSprit.Panel2.SuspendLayout();
            this.TextBoxSprit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JimakuSprit)).BeginInit();
            this.JimakuSprit.Panel1.SuspendLayout();
            this.JimakuSprit.Panel2.SuspendLayout();
            this.JimakuSprit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HatsuonSprit)).BeginInit();
            this.HatsuonSprit.Panel1.SuspendLayout();
            this.HatsuonSprit.Panel2.SuspendLayout();
            this.HatsuonSprit.SuspendLayout();
            this.GeneratePanel.SuspendLayout();
            this.ProfileListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ProfileSelectSprit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            // 
            // ProfileSelectSprit
            // 
            this.ProfileSelectSprit.BackColor = System.Drawing.Color.White;
            this.ProfileSelectSprit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileSelectSprit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.ProfileSelectSprit.IsSplitterFixed = true;
            this.ProfileSelectSprit.Location = new System.Drawing.Point(0, 0);
            this.ProfileSelectSprit.Name = "ProfileSelectSprit";
            this.ProfileSelectSprit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ProfileSelectSprit.Panel1
            // 
            this.ProfileSelectSprit.Panel1.Controls.Add(this.ProfileListBox);
            // 
            // ProfileSelectSprit.Panel2
            // 
            this.ProfileSelectSprit.Panel2.Controls.Add(this.SettingButton);
            this.ProfileSelectSprit.Panel2MinSize = 0;
            this.ProfileSelectSprit.Size = new System.Drawing.Size(218, 450);
            this.ProfileSelectSprit.SplitterDistance = 424;
            this.ProfileSelectSprit.SplitterWidth = 1;
            this.ProfileSelectSprit.TabIndex = 0;
            // 
            // ProfileListBox
            // 
            this.ProfileListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileListBox.FormattingEnabled = true;
            this.ProfileListBox.ItemHeight = 12;
            this.ProfileListBox.Location = new System.Drawing.Point(0, 0);
            this.ProfileListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProfileListBox.Name = "ProfileListBox";
            this.ProfileListBox.Size = new System.Drawing.Size(218, 424);
            this.ProfileListBox.TabIndex = 0;
            this.ProfileListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProfileListBox_MouseDown);
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SettingButton.Location = new System.Drawing.Point(0, 0);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(218, 25);
            this.SettingButton.TabIndex = 0;
            this.SettingButton.Text = "設定";
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TextBoxSprit);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.GeneratePanel);
            this.splitContainer2.Size = new System.Drawing.Size(578, 450);
            this.splitContainer2.SplitterDistance = 383;
            this.splitContainer2.TabIndex = 0;
            // 
            // TextBoxSprit
            // 
            this.TextBoxSprit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSprit.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSprit.Name = "TextBoxSprit";
            this.TextBoxSprit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TextBoxSprit.Panel1
            // 
            this.TextBoxSprit.Panel1.Controls.Add(this.JimakuSprit);
            // 
            // TextBoxSprit.Panel2
            // 
            this.TextBoxSprit.Panel2.Controls.Add(this.HatsuonSprit);
            this.TextBoxSprit.Size = new System.Drawing.Size(383, 450);
            this.TextBoxSprit.SplitterDistance = 220;
            this.TextBoxSprit.TabIndex = 0;
            // 
            // JimakuSprit
            // 
            this.JimakuSprit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JimakuSprit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.JimakuSprit.IsSplitterFixed = true;
            this.JimakuSprit.Location = new System.Drawing.Point(0, 0);
            this.JimakuSprit.Name = "JimakuSprit";
            this.JimakuSprit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // JimakuSprit.Panel1
            // 
            this.JimakuSprit.Panel1.Controls.Add(this.JimakuLabel);
            // 
            // JimakuSprit.Panel2
            // 
            this.JimakuSprit.Panel2.Controls.Add(this.JimakuBox);
            this.JimakuSprit.Size = new System.Drawing.Size(383, 220);
            this.JimakuSprit.SplitterDistance = 28;
            this.JimakuSprit.SplitterWidth = 1;
            this.JimakuSprit.TabIndex = 1;
            // 
            // JimakuLabel
            // 
            this.JimakuLabel.AutoSize = true;
            this.JimakuLabel.Location = new System.Drawing.Point(3, 9);
            this.JimakuLabel.Name = "JimakuLabel";
            this.JimakuLabel.Size = new System.Drawing.Size(29, 12);
            this.JimakuLabel.TabIndex = 0;
            this.JimakuLabel.Text = "字幕";
            // 
            // JimakuBox
            // 
            this.JimakuBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JimakuBox.Location = new System.Drawing.Point(0, 0);
            this.JimakuBox.Multiline = true;
            this.JimakuBox.Name = "JimakuBox";
            this.JimakuBox.Size = new System.Drawing.Size(383, 191);
            this.JimakuBox.TabIndex = 0;
            // 
            // HatsuonSprit
            // 
            this.HatsuonSprit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HatsuonSprit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HatsuonSprit.Location = new System.Drawing.Point(0, 0);
            this.HatsuonSprit.Name = "HatsuonSprit";
            this.HatsuonSprit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HatsuonSprit.Panel1
            // 
            this.HatsuonSprit.Panel1.Controls.Add(this.JimakuCopy_Check);
            this.HatsuonSprit.Panel1.Controls.Add(this.HatsuonLabel);
            // 
            // HatsuonSprit.Panel2
            // 
            this.HatsuonSprit.Panel2.Controls.Add(this.HatsuonBox);
            this.HatsuonSprit.Size = new System.Drawing.Size(383, 226);
            this.HatsuonSprit.SplitterDistance = 25;
            this.HatsuonSprit.TabIndex = 0;
            // 
            // JimakuCopy_Check
            // 
            this.JimakuCopy_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JimakuCopy_Check.AutoSize = true;
            this.JimakuCopy_Check.Location = new System.Drawing.Point(296, 6);
            this.JimakuCopy_Check.Name = "JimakuCopy_Check";
            this.JimakuCopy_Check.Size = new System.Drawing.Size(84, 16);
            this.JimakuCopy_Check.TabIndex = 1;
            this.JimakuCopy_Check.Text = "字幕をコピー";
            this.JimakuCopy_Check.UseVisualStyleBackColor = true;
            // 
            // HatsuonLabel
            // 
            this.HatsuonLabel.AutoSize = true;
            this.HatsuonLabel.Location = new System.Drawing.Point(3, 6);
            this.HatsuonLabel.Name = "HatsuonLabel";
            this.HatsuonLabel.Size = new System.Drawing.Size(53, 12);
            this.HatsuonLabel.TabIndex = 0;
            this.HatsuonLabel.Text = "発音記号";
            // 
            // HatsuonBox
            // 
            this.HatsuonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HatsuonBox.Location = new System.Drawing.Point(0, 0);
            this.HatsuonBox.Multiline = true;
            this.HatsuonBox.Name = "HatsuonBox";
            this.HatsuonBox.Size = new System.Drawing.Size(383, 197);
            this.HatsuonBox.TabIndex = 0;
            // 
            // GeneratePanel
            // 
            this.GeneratePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GeneratePanel.Controls.Add(this.GenerateLabel);
            this.GeneratePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratePanel.Location = new System.Drawing.Point(0, 0);
            this.GeneratePanel.Name = "GeneratePanel";
            this.GeneratePanel.Size = new System.Drawing.Size(191, 450);
            this.GeneratePanel.TabIndex = 0;
            this.GeneratePanel.Click += new System.EventHandler(this.GeneratePanel_Click);
            // 
            // ProfileListContextMenu
            // 
            this.ProfileListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.プロファイルを追加ToolStripMenuItem,
            this.プロファイルを編集ToolStripMenuItem,
            this.プロファイルを削除ToolStripMenuItem});
            this.ProfileListContextMenu.Name = "ProfileListContextMenu";
            this.ProfileListContextMenu.Size = new System.Drawing.Size(184, 70);
            // 
            // プロファイルを追加ToolStripMenuItem
            // 
            this.プロファイルを追加ToolStripMenuItem.Name = "プロファイルを追加ToolStripMenuItem";
            this.プロファイルを追加ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.プロファイルを追加ToolStripMenuItem.Text = "プロファイルを新規作成";
            this.プロファイルを追加ToolStripMenuItem.Click += new System.EventHandler(this.プロファイルを追加ToolStripMenuItem_Click);
            // 
            // プロファイルを編集ToolStripMenuItem
            // 
            this.プロファイルを編集ToolStripMenuItem.Name = "プロファイルを編集ToolStripMenuItem";
            this.プロファイルを編集ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.プロファイルを編集ToolStripMenuItem.Text = "プロファイルを編集";
            // 
            // プロファイルを削除ToolStripMenuItem
            // 
            this.プロファイルを削除ToolStripMenuItem.Name = "プロファイルを削除ToolStripMenuItem";
            this.プロファイルを削除ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.プロファイルを削除ToolStripMenuItem.Text = "プロファイルを削除";
            // 
            // GenerateLabel
            // 
            this.GenerateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateLabel.AutoSize = true;
            this.GenerateLabel.Location = new System.Drawing.Point(43, 224);
            this.GenerateLabel.Name = "GenerateLabel";
            this.GenerateLabel.Size = new System.Drawing.Size(102, 12);
            this.GenerateLabel.TabIndex = 0;
            this.GenerateLabel.Text = "クリックで音声を生成";
            this.GenerateLabel.Click += new System.EventHandler(this.GeneratePanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "AqT_Utl";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ProfileSelectSprit.Panel1.ResumeLayout(false);
            this.ProfileSelectSprit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileSelectSprit)).EndInit();
            this.ProfileSelectSprit.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.TextBoxSprit.Panel1.ResumeLayout(false);
            this.TextBoxSprit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSprit)).EndInit();
            this.TextBoxSprit.ResumeLayout(false);
            this.JimakuSprit.Panel1.ResumeLayout(false);
            this.JimakuSprit.Panel1.PerformLayout();
            this.JimakuSprit.Panel2.ResumeLayout(false);
            this.JimakuSprit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JimakuSprit)).EndInit();
            this.JimakuSprit.ResumeLayout(false);
            this.HatsuonSprit.Panel1.ResumeLayout(false);
            this.HatsuonSprit.Panel1.PerformLayout();
            this.HatsuonSprit.Panel2.ResumeLayout(false);
            this.HatsuonSprit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HatsuonSprit)).EndInit();
            this.HatsuonSprit.ResumeLayout(false);
            this.GeneratePanel.ResumeLayout(false);
            this.GeneratePanel.PerformLayout();
            this.ProfileListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer ProfileSelectSprit;
        private System.Windows.Forms.ListBox ProfileListBox;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Panel GeneratePanel;
        private System.Windows.Forms.SplitContainer TextBoxSprit;
        private System.Windows.Forms.Label JimakuLabel;
        private System.Windows.Forms.Label HatsuonLabel;
        private System.Windows.Forms.SplitContainer JimakuSprit;
        private System.Windows.Forms.TextBox JimakuBox;
        private System.Windows.Forms.SplitContainer HatsuonSprit;
        private System.Windows.Forms.TextBox HatsuonBox;
        private System.Windows.Forms.CheckBox JimakuCopy_Check;
        private System.Windows.Forms.ContextMenuStrip ProfileListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem プロファイルを追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プロファイルを編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem プロファイルを削除ToolStripMenuItem;
        private System.Windows.Forms.Label GenerateLabel;
    }
}

