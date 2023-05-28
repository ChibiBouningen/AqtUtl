using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            output_folderBox.Text = Properties.Settings.Default.output_folder;
            FPScomboBox.Text = Properties.Settings.Default.fps_AviUtl.ToString();
            JimakuCheck.Checked = Properties.Settings.Default.jimakuCopy_startup;
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.output_folder = output_folderBox.Text;
            int a;
            if(int.TryParse(FPScomboBox.Text, out a))
            {
                Properties.Settings.Default.fps_AviUtl = int.Parse(FPScomboBox.Text);
            }
            else
            {
                MessageBox.Show("項目「AviUtlのFPS」の値が正しくありません");
                e.Cancel = true;
            }
            Properties.Settings.Default.jimakuCopy_startup = JimakuCheck.Checked;
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            output_folderBox.Text = Properties.Settings.Default.output_folder;
            FPScomboBox.Text = Properties.Settings.Default.fps_AviUtl.ToString();
            JimakuCheck.Checked = Properties.Settings.Default.jimakuCopy_startup;
        }
    }
}
