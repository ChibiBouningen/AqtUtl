namespace AqT_Utl
{
    partial class Setting
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
            this.DefaultButton = new System.Windows.Forms.Button();
            this.output_folderBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FPScomboBox = new System.Windows.Forms.ComboBox();
            this.JimakuCheck = new System.Windows.Forms.CheckBox();
            this.GCMZcheck = new System.Windows.Forms.CheckBox();
            this.KaisetsuTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "音声出力パス";
            // 
            // DefaultButton
            // 
            this.DefaultButton.Location = new System.Drawing.Point(242, 15);
            this.DefaultButton.Margin = new System.Windows.Forms.Padding(4);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(109, 29);
            this.DefaultButton.TabIndex = 1;
            this.DefaultButton.Text = "初期値に戻す";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // output_folderBox
            // 
            this.output_folderBox.Location = new System.Drawing.Point(17, 62);
            this.output_folderBox.Margin = new System.Windows.Forms.Padding(4);
            this.output_folderBox.Name = "output_folderBox";
            this.output_folderBox.Size = new System.Drawing.Size(336, 23);
            this.output_folderBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "AviUtlのFPS";
            // 
            // FPScomboBox
            // 
            this.FPScomboBox.FormattingEnabled = true;
            this.FPScomboBox.Items.AddRange(new object[] {
            "60",
            "30",
            "24"});
            this.FPScomboBox.Location = new System.Drawing.Point(17, 122);
            this.FPScomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FPScomboBox.Name = "FPScomboBox";
            this.FPScomboBox.Size = new System.Drawing.Size(119, 23);
            this.FPScomboBox.TabIndex = 5;
            // 
            // JimakuCheck
            // 
            this.JimakuCheck.AutoSize = true;
            this.JimakuCheck.Location = new System.Drawing.Point(150, 124);
            this.JimakuCheck.Margin = new System.Windows.Forms.Padding(4);
            this.JimakuCheck.Name = "JimakuCheck";
            this.JimakuCheck.Size = new System.Drawing.Size(174, 19);
            this.JimakuCheck.TabIndex = 7;
            this.JimakuCheck.Text = "起動時「字幕をコピー」にチェック";
            this.JimakuCheck.UseVisualStyleBackColor = true;
            // 
            // GCMZcheck
            // 
            this.GCMZcheck.AutoSize = true;
            this.GCMZcheck.Location = new System.Drawing.Point(17, 163);
            this.GCMZcheck.Name = "GCMZcheck";
            this.GCMZcheck.Size = new System.Drawing.Size(145, 19);
            this.GCMZcheck.TabIndex = 8;
            this.GCMZcheck.Text = "ごちゃまぜドロップスと連携";
            this.GCMZcheck.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 194);
            this.Controls.Add(this.GCMZcheck);
            this.Controls.Add(this.JimakuCheck);
            this.Controls.Add(this.FPScomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_folderBox);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Setting";
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.TextBox output_folderBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FPScomboBox;
        private System.Windows.Forms.CheckBox JimakuCheck;
        private System.Windows.Forms.CheckBox GCMZcheck;
        private System.Windows.Forms.ToolTip KaisetsuTip;
    }
}