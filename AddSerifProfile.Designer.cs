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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MakeProfileButton = new System.Windows.Forms.Button();
            this.AquesPresetNameBox = new System.Windows.Forms.TextBox();
            this.exoLabel = new System.Windows.Forms.Label();
            this.exoBox = new System.Windows.Forms.TextBox();
            this.jimakuCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HoseiBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LayerBox = new System.Windows.Forms.TextBox();
            this.KaisetsuTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "プロファイル名";
            // 
            // ProfileNameBox
            // 
            this.ProfileNameBox.Location = new System.Drawing.Point(35, 50);
            this.ProfileNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileNameBox.Name = "ProfileNameBox";
            this.ProfileNameBox.Size = new System.Drawing.Size(176, 23);
            this.ProfileNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "AquesTalkPlayerのプリセット名";
            // 
            // MakeProfileButton
            // 
            this.MakeProfileButton.Location = new System.Drawing.Point(35, 360);
            this.MakeProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.MakeProfileButton.Name = "MakeProfileButton";
            this.MakeProfileButton.Size = new System.Drawing.Size(428, 29);
            this.MakeProfileButton.TabIndex = 7;
            this.MakeProfileButton.Text = "適用";
            this.MakeProfileButton.UseVisualStyleBackColor = true;
            this.MakeProfileButton.Click += new System.EventHandler(this.MakeProfileButton_Click);
            // 
            // AquesPresetNameBox
            // 
            this.AquesPresetNameBox.Location = new System.Drawing.Point(35, 108);
            this.AquesPresetNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.AquesPresetNameBox.Name = "AquesPresetNameBox";
            this.AquesPresetNameBox.Size = new System.Drawing.Size(176, 23);
            this.AquesPresetNameBox.TabIndex = 2;
            // 
            // exoLabel
            // 
            this.exoLabel.AutoSize = true;
            this.exoLabel.Location = new System.Drawing.Point(136, 149);
            this.exoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exoLabel.Name = "exoLabel";
            this.exoLabel.Size = new System.Drawing.Size(28, 15);
            this.exoLabel.TabIndex = 5;
            this.exoLabel.Text = "exo";
            // 
            // exoBox
            // 
            this.exoBox.Location = new System.Drawing.Point(35, 168);
            this.exoBox.Margin = new System.Windows.Forms.Padding(4);
            this.exoBox.Multiline = true;
            this.exoBox.Name = "exoBox";
            this.exoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exoBox.Size = new System.Drawing.Size(428, 184);
            this.exoBox.TabIndex = 6;
            // 
            // jimakuCheck
            // 
            this.jimakuCheck.AutoSize = true;
            this.jimakuCheck.Location = new System.Drawing.Point(35, 148);
            this.jimakuCheck.Margin = new System.Windows.Forms.Padding(4);
            this.jimakuCheck.Name = "jimakuCheck";
            this.jimakuCheck.Size = new System.Drawing.Size(83, 19);
            this.jimakuCheck.TabIndex = 5;
            this.jimakuCheck.Text = "字幕を付与";
            this.jimakuCheck.UseVisualStyleBackColor = true;
            this.jimakuCheck.CheckedChanged += new System.EventHandler(this.jimakuCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "音声の長さ補正";
            // 
            // HoseiBox
            // 
            this.HoseiBox.Location = new System.Drawing.Point(266, 50);
            this.HoseiBox.Margin = new System.Windows.Forms.Padding(4);
            this.HoseiBox.Name = "HoseiBox";
            this.HoseiBox.Size = new System.Drawing.Size(100, 23);
            this.HoseiBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "挿入するレイヤー";
            // 
            // LayerBox
            // 
            this.LayerBox.Location = new System.Drawing.Point(266, 108);
            this.LayerBox.Name = "LayerBox";
            this.LayerBox.Size = new System.Drawing.Size(100, 23);
            this.LayerBox.TabIndex = 12;
            // 
            // AddSerifProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 404);
            this.Controls.Add(this.LayerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HoseiBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jimakuCheck);
            this.Controls.Add(this.exoBox);
            this.Controls.Add(this.exoLabel);
            this.Controls.Add(this.AquesPresetNameBox);
            this.Controls.Add(this.MakeProfileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProfileNameBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSerifProfile";
            this.Text = "プロファイルの編集";
            this.TopMost = true;
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
        public System.Windows.Forms.TextBox AquesPresetNameBox;
        public System.Windows.Forms.TextBox exoBox;
        public System.Windows.Forms.CheckBox jimakuCheck;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox HoseiBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox LayerBox;
        private System.Windows.Forms.ToolTip KaisetsuTip;
    }
}