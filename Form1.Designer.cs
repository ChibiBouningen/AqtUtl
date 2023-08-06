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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListAnnaiLabel = new System.Windows.Forms.Label();
            this.ProfileListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TextBoxSprit = new System.Windows.Forms.SplitContainer();
            this.JimakuSprit = new System.Windows.Forms.SplitContainer();
            this.JimakuLabel = new System.Windows.Forms.Label();
            this.JimakuBox = new System.Windows.Forms.TextBox();
            this.HatsuonSprit = new System.Windows.Forms.SplitContainer();
            this.JimakuCopy_Check = new System.Windows.Forms.CheckBox();
            this.HatsuonLabel = new System.Windows.Forms.Label();
            this.HatsuonBox = new System.Windows.Forms.TextBox();
            this.RightSpritContainer = new System.Windows.Forms.SplitContainer();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.GeneratePanel = new System.Windows.Forms.Panel();
            this.GenerateLabel = new System.Windows.Forms.Label();
            this.ProfileListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KaisetsuTip = new System.Windows.Forms.ToolTip(this.components);
            this.aqtUtlについてToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aquesTalkPlayerを起動ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aqtUtlを終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロファイルを追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロファイルを編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.プロファイルを削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.RightSpritContainer)).BeginInit();
            this.RightSpritContainer.Panel1.SuspendLayout();
            this.RightSpritContainer.Panel2.SuspendLayout();
            this.RightSpritContainer.SuspendLayout();
            this.PlayPanel.SuspendLayout();
            this.GeneratePanel.SuspendLayout();
            this.ProfileListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListAnnaiLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ProfileListBox);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            // 
            // ListAnnaiLabel
            // 
            this.ListAnnaiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListAnnaiLabel.AutoSize = true;
            this.ListAnnaiLabel.BackColor = System.Drawing.Color.White;
            this.ListAnnaiLabel.Location = new System.Drawing.Point(41, 221);
            this.ListAnnaiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListAnnaiLabel.Name = "ListAnnaiLabel";
            this.ListAnnaiLabel.Size = new System.Drawing.Size(92, 30);
            this.ListAnnaiLabel.TabIndex = 1;
            this.ListAnnaiLabel.Text = "右クリックで\r\nプロファイルを作成";
            this.ListAnnaiLabel.Visible = false;
            this.ListAnnaiLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProfileListBox_MouseDown);
            // 
            // ProfileListBox
            // 
            this.ProfileListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileListBox.FormattingEnabled = true;
            this.ProfileListBox.ItemHeight = 15;
            this.ProfileListBox.Location = new System.Drawing.Point(0, 32);
            this.ProfileListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProfileListBox.Name = "ProfileListBox";
            this.ProfileListBox.Size = new System.Drawing.Size(218, 418);
            this.ProfileListBox.TabIndex = 0;
            this.ProfileListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProfileListBox_MouseDown);
            this.ProfileListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProfileListBox_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ツールToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(218, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ツールToolStripMenuItem
            // 
            this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aqtUtlについてToolStripMenuItem,
            this.aquesTalkPlayerを起動ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.aqtUtlを終了ToolStripMenuItem});
            this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            this.ツールToolStripMenuItem.Size = new System.Drawing.Size(46, 28);
            this.ツールToolStripMenuItem.Text = "ツール";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TextBoxSprit);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.RightSpritContainer);
            this.splitContainer2.Size = new System.Drawing.Size(578, 450);
            this.splitContainer2.SplitterDistance = 380;
            this.splitContainer2.TabIndex = 0;
            // 
            // TextBoxSprit
            // 
            this.TextBoxSprit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSprit.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSprit.Margin = new System.Windows.Forms.Padding(4);
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
            this.TextBoxSprit.Size = new System.Drawing.Size(380, 450);
            this.TextBoxSprit.SplitterDistance = 220;
            this.TextBoxSprit.SplitterWidth = 5;
            this.TextBoxSprit.TabIndex = 0;
            // 
            // JimakuSprit
            // 
            this.JimakuSprit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JimakuSprit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.JimakuSprit.IsSplitterFixed = true;
            this.JimakuSprit.Location = new System.Drawing.Point(0, 0);
            this.JimakuSprit.Margin = new System.Windows.Forms.Padding(4);
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
            this.JimakuSprit.Size = new System.Drawing.Size(380, 220);
            this.JimakuSprit.SplitterDistance = 28;
            this.JimakuSprit.SplitterWidth = 1;
            this.JimakuSprit.TabIndex = 1;
            // 
            // JimakuLabel
            // 
            this.JimakuLabel.AutoSize = true;
            this.JimakuLabel.Location = new System.Drawing.Point(4, 9);
            this.JimakuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JimakuLabel.Name = "JimakuLabel";
            this.JimakuLabel.Size = new System.Drawing.Size(31, 15);
            this.JimakuLabel.TabIndex = 0;
            this.JimakuLabel.Text = "字幕";
            // 
            // JimakuBox
            // 
            this.JimakuBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JimakuBox.Location = new System.Drawing.Point(0, 0);
            this.JimakuBox.Margin = new System.Windows.Forms.Padding(4);
            this.JimakuBox.Multiline = true;
            this.JimakuBox.Name = "JimakuBox";
            this.JimakuBox.Size = new System.Drawing.Size(380, 191);
            this.JimakuBox.TabIndex = 0;
            this.JimakuBox.TextChanged += new System.EventHandler(this.JimakuBox_TextChanged);
            // 
            // HatsuonSprit
            // 
            this.HatsuonSprit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HatsuonSprit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HatsuonSprit.IsSplitterFixed = true;
            this.HatsuonSprit.Location = new System.Drawing.Point(0, 0);
            this.HatsuonSprit.Margin = new System.Windows.Forms.Padding(4);
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
            this.HatsuonSprit.Size = new System.Drawing.Size(380, 225);
            this.HatsuonSprit.SplitterDistance = 25;
            this.HatsuonSprit.SplitterWidth = 5;
            this.HatsuonSprit.TabIndex = 0;
            // 
            // JimakuCopy_Check
            // 
            this.JimakuCopy_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JimakuCopy_Check.AutoSize = true;
            this.JimakuCopy_Check.Location = new System.Drawing.Point(290, 6);
            this.JimakuCopy_Check.Margin = new System.Windows.Forms.Padding(4);
            this.JimakuCopy_Check.Name = "JimakuCopy_Check";
            this.JimakuCopy_Check.Size = new System.Drawing.Size(86, 19);
            this.JimakuCopy_Check.TabIndex = 1;
            this.JimakuCopy_Check.Text = "字幕をコピー";
            this.JimakuCopy_Check.UseVisualStyleBackColor = true;
            this.JimakuCopy_Check.Click += new System.EventHandler(this.JimakuCopy_Check_Click);
            // 
            // HatsuonLabel
            // 
            this.HatsuonLabel.AutoSize = true;
            this.HatsuonLabel.Location = new System.Drawing.Point(4, 7);
            this.HatsuonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HatsuonLabel.Name = "HatsuonLabel";
            this.HatsuonLabel.Size = new System.Drawing.Size(55, 15);
            this.HatsuonLabel.TabIndex = 0;
            this.HatsuonLabel.Text = "発音記号";
            // 
            // HatsuonBox
            // 
            this.HatsuonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HatsuonBox.Location = new System.Drawing.Point(0, 0);
            this.HatsuonBox.Margin = new System.Windows.Forms.Padding(4);
            this.HatsuonBox.Multiline = true;
            this.HatsuonBox.Name = "HatsuonBox";
            this.HatsuonBox.Size = new System.Drawing.Size(380, 195);
            this.HatsuonBox.TabIndex = 0;
            this.HatsuonBox.TextChanged += new System.EventHandler(this.HatsuonBox_TextChanged);
            // 
            // RightSpritContainer
            // 
            this.RightSpritContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSpritContainer.Location = new System.Drawing.Point(0, 0);
            this.RightSpritContainer.Name = "RightSpritContainer";
            this.RightSpritContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RightSpritContainer.Panel1
            // 
            this.RightSpritContainer.Panel1.Controls.Add(this.PlayPanel);
            this.RightSpritContainer.Panel1MinSize = 0;
            // 
            // RightSpritContainer.Panel2
            // 
            this.RightSpritContainer.Panel2.Controls.Add(this.GeneratePanel);
            this.RightSpritContainer.Panel2MinSize = 0;
            this.RightSpritContainer.Size = new System.Drawing.Size(194, 450);
            this.RightSpritContainer.SplitterDistance = 64;
            this.RightSpritContainer.TabIndex = 0;
            // 
            // PlayPanel
            // 
            this.PlayPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.PlayPanel.Controls.Add(this.PlayLabel);
            this.PlayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayPanel.Location = new System.Drawing.Point(0, 0);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(194, 64);
            this.PlayPanel.TabIndex = 0;
            this.PlayPanel.Click += new System.EventHandler(this.PlayPanel_Click);
            // 
            // PlayLabel
            // 
            this.PlayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayLabel.Location = new System.Drawing.Point(59, 29);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(71, 15);
            this.PlayLabel.TabIndex = 0;
            this.PlayLabel.Text = "クリックで試聴";
            this.PlayLabel.Click += new System.EventHandler(this.PlayPanel_Click);
            // 
            // GeneratePanel
            // 
            this.GeneratePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.GeneratePanel.Controls.Add(this.GenerateLabel);
            this.GeneratePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratePanel.Location = new System.Drawing.Point(0, 0);
            this.GeneratePanel.Margin = new System.Windows.Forms.Padding(4);
            this.GeneratePanel.Name = "GeneratePanel";
            this.GeneratePanel.Size = new System.Drawing.Size(194, 382);
            this.GeneratePanel.TabIndex = 0;
            this.GeneratePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneratePanel_MouseDown);
            // 
            // GenerateLabel
            // 
            this.GenerateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateLabel.AutoSize = true;
            this.GenerateLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenerateLabel.Location = new System.Drawing.Point(45, 190);
            this.GenerateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenerateLabel.Name = "GenerateLabel";
            this.GenerateLabel.Size = new System.Drawing.Size(104, 15);
            this.GenerateLabel.TabIndex = 0;
            this.GenerateLabel.Text = "クリックで音声を生成";
            this.GenerateLabel.TextChanged += new System.EventHandler(this.GenerateLabel_TextChanged);
            this.GenerateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneratePanel_MouseDown);
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
            // aqtUtlについてToolStripMenuItem
            // 
            this.aqtUtlについてToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aqtUtlについてToolStripMenuItem.Image = global::AqT_Utl.Properties.Resources.info;
            this.aqtUtlについてToolStripMenuItem.Name = "aqtUtlについてToolStripMenuItem";
            this.aqtUtlについてToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aqtUtlについてToolStripMenuItem.Text = "AqtUtlについて";
            this.aqtUtlについてToolStripMenuItem.Click += new System.EventHandler(this.aqtUtlについてToolStripMenuItem_Click);
            // 
            // aquesTalkPlayerを起動ToolStripMenuItem
            // 
            this.aquesTalkPlayerを起動ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aquesTalkPlayerを起動ToolStripMenuItem.Image = global::AqT_Utl.Properties.Resources.ad_group;
            this.aquesTalkPlayerを起動ToolStripMenuItem.Name = "aquesTalkPlayerを起動ToolStripMenuItem";
            this.aquesTalkPlayerを起動ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aquesTalkPlayerを起動ToolStripMenuItem.Text = "AquesTalkPlayerを起動";
            this.aquesTalkPlayerを起動ToolStripMenuItem.Click += new System.EventHandler(this.aquesTalkPlayerを起動ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.設定ToolStripMenuItem.Image = global::AqT_Utl.Properties.Resources.setting;
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // aqtUtlを終了ToolStripMenuItem
            // 
            this.aqtUtlを終了ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aqtUtlを終了ToolStripMenuItem.Image = global::AqT_Utl.Properties.Resources.exitapp;
            this.aqtUtlを終了ToolStripMenuItem.Name = "aqtUtlを終了ToolStripMenuItem";
            this.aqtUtlを終了ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aqtUtlを終了ToolStripMenuItem.Text = "AqtUtlを終了";
            this.aqtUtlを終了ToolStripMenuItem.Click += new System.EventHandler(this.aqtUtlを終了ToolStripMenuItem_Click);
            // 
            // プロファイルを追加ToolStripMenuItem
            // 
            this.プロファイルを追加ToolStripMenuItem.Image = global::AqT_Utl.Properties.Resources.add;
            this.プロファイルを追加ToolStripMenuItem.Name = "プロファイルを追加ToolStripMenuItem";
            this.プロファイルを追加ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.プロファイルを追加ToolStripMenuItem.Text = "プロファイルを新規作成";
            this.プロファイルを追加ToolStripMenuItem.Click += new System.EventHandler(this.プロファイルを追加ToolStripMenuItem_Click);
            // 
            // プロファイルを編集ToolStripMenuItem
            // 
            this.プロファイルを編集ToolStripMenuItem.Image = global::AqT_Utl.Properties.Resources.edit;
            this.プロファイルを編集ToolStripMenuItem.Name = "プロファイルを編集ToolStripMenuItem";
            this.プロファイルを編集ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.プロファイルを編集ToolStripMenuItem.Text = "プロファイルを編集";
            this.プロファイルを編集ToolStripMenuItem.Click += new System.EventHandler(this.プロファイルを編集ToolStripMenuItem_Click);
            // 
            // プロファイルを削除ToolStripMenuItem
            // 
            this.プロファイルを削除ToolStripMenuItem.Image = global::AqT_Utl.Properties.Resources.delete;
            this.プロファイルを削除ToolStripMenuItem.Name = "プロファイルを削除ToolStripMenuItem";
            this.プロファイルを削除ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.プロファイルを削除ToolStripMenuItem.Text = "プロファイルを削除";
            this.プロファイルを削除ToolStripMenuItem.Click += new System.EventHandler(this.プロファイルを削除ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AqtUtl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
            this.RightSpritContainer.Panel1.ResumeLayout(false);
            this.RightSpritContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightSpritContainer)).EndInit();
            this.RightSpritContainer.ResumeLayout(false);
            this.PlayPanel.ResumeLayout(false);
            this.PlayPanel.PerformLayout();
            this.GeneratePanel.ResumeLayout(false);
            this.GeneratePanel.PerformLayout();
            this.ProfileListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox ProfileListBox;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aquesTalkPlayerを起動ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aqtUtlを終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aqtUtlについてToolStripMenuItem;
        private System.Windows.Forms.Label ListAnnaiLabel;
        private System.Windows.Forms.SplitContainer RightSpritContainer;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.ToolTip KaisetsuTip;
    }
}

