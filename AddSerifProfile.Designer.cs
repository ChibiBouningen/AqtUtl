namespace AqT_Utl
{
    partial class AddSerifProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MakeProfileButton = new System.Windows.Forms.Button();
            this.AquesPresetNameBox = new System.Windows.Forms.TextBox();
            this.exoLabel = new System.Windows.Forms.Label();
            this.exoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.jimakuCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HoseiBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "キャラクタ プロファイル名";
            // 
            // ProfileNameBox
            // 
            this.ProfileNameBox.Location = new System.Drawing.Point(30, 40);
            this.ProfileNameBox.Name = "ProfileNameBox";
            this.ProfileNameBox.Size = new System.Drawing.Size(152, 19);
            this.ProfileNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "AquesTalkPlayerのプリセット名";
            // 
            // MakeProfileButton
            // 
            this.MakeProfileButton.Location = new System.Drawing.Point(30, 288);
            this.MakeProfileButton.Name = "MakeProfileButton";
            this.MakeProfileButton.Size = new System.Drawing.Size(367, 23);
            this.MakeProfileButton.TabIndex = 3;
            this.MakeProfileButton.Text = "適用";
            this.MakeProfileButton.UseVisualStyleBackColor = true;
            this.MakeProfileButton.Click += new System.EventHandler(this.MakeProfileButton_Click);
            // 
            // AquesPresetNameBox
            // 
            this.AquesPresetNameBox.Location = new System.Drawing.Point(30, 86);
            this.AquesPresetNameBox.Name = "AquesPresetNameBox";
            this.AquesPresetNameBox.Size = new System.Drawing.Size(152, 19);
            this.AquesPresetNameBox.TabIndex = 4;
            // 
            // exoLabel
            // 
            this.exoLabel.AutoSize = true;
            this.exoLabel.Location = new System.Drawing.Point(117, 119);
            this.exoLabel.Name = "exoLabel";
            this.exoLabel.Size = new System.Drawing.Size(23, 12);
            this.exoLabel.TabIndex = 5;
            this.exoLabel.Text = "exo";
            // 
            // exoBox
            // 
            this.exoBox.Location = new System.Drawing.Point(30, 134);
            this.exoBox.Multiline = true;
            this.exoBox.Name = "exoBox";
            this.exoBox.Size = new System.Drawing.Size(367, 148);
            this.exoBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "並べ替えの優先順位(大きいほど高い)";
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.sortComboBox.Location = new System.Drawing.Point(213, 40);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(84, 20);
            this.sortComboBox.TabIndex = 8;
            this.sortComboBox.Text = "5";
            // 
            // jimakuCheck
            // 
            this.jimakuCheck.AutoSize = true;
            this.jimakuCheck.Location = new System.Drawing.Point(30, 118);
            this.jimakuCheck.Name = "jimakuCheck";
            this.jimakuCheck.Size = new System.Drawing.Size(81, 16);
            this.jimakuCheck.TabIndex = 9;
            this.jimakuCheck.Text = "字幕を付与";
            this.jimakuCheck.UseVisualStyleBackColor = true;
            this.jimakuCheck.CheckedChanged += new System.EventHandler(this.jimakuCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "音声の長さ補正";
            // 
            // HoseiBox
            // 
            this.HoseiBox.Location = new System.Drawing.Point(213, 86);
            this.HoseiBox.Name = "HoseiBox";
            this.HoseiBox.Size = new System.Drawing.Size(84, 19);
            this.HoseiBox.TabIndex = 11;
            // 
            // AddSerifProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 323);
            this.Controls.Add(this.HoseiBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jimakuCheck);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exoBox);
            this.Controls.Add(this.exoLabel);
            this.Controls.Add(this.AquesPresetNameBox);
            this.Controls.Add(this.MakeProfileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProfileNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSerifProfile";
            this.Text = "セリフ プロパティの編集";
            this.Load += new System.EventHandler(this.AddSerifProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MakeProfileButton;
        public System.Windows.Forms.TextBox ProfileNameBox;
        private System.Windows.Forms.Label exoLabel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox AquesPresetNameBox;
        public System.Windows.Forms.TextBox exoBox;
        public System.Windows.Forms.ComboBox sortComboBox;
        public System.Windows.Forms.CheckBox jimakuCheck;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox HoseiBox;
    }
}