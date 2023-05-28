using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            infomationLabel.Text = Assembly.GetExecutingAssembly().GetName().Name + "  " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            infomationLabel.Text += "\nCopyright ちびすけ 2023";
        }

        private void GitHubLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GitHubLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/ChibiBouningen/AqtUtl");
        }
    }
}
