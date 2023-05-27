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
            this.ProfileNameBox.Location = new System.Drawing.Point(30, 52);
            this.ProfileNameBox.Name = "ProfileNameBox";
            this.ProfileNameBox.Size = new System.Drawing.Size(431, 19);
            this.ProfileNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "AquesTalkPlayerのプリセット名";
            // 
            // MakeProfileButton
            // 
            this.MakeProfileButton.Location = new System.Drawing.Point(386, 288);
            this.MakeProfileButton.Name = "MakeProfileButton";
            this.MakeProfileButton.Size = new System.Drawing.Size(75, 23);
            this.MakeProfileButton.TabIndex = 3;
            this.MakeProfileButton.Text = "作成";
            this.MakeProfileButton.UseVisualStyleBackColor = true;
            this.MakeProfileButton.Click += new System.EventHandler(this.MakeProfileButton_Click);
            // 
            // AddSerifProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 323);
            this.Controls.Add(this.MakeProfileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProfileNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddSerifProfile";
            this.Text = "AddSerifProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MakeProfileButton;
        public System.Windows.Forms.TextBox ProfileNameBox;
    }
}