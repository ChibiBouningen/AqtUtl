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
    public partial class Form1 : Form
    {
        AquesTalkPlayerManager playerManager;
        public Form1()
        {
            InitializeComponent();
            playerManager = new AquesTalkPlayerManager();
            playerManager.RegistPlayer();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            //ProfileListBox.Items.Add(DateTime.Now.ToString());
        }

        private void ProfileListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = ProfileListBox.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    ProfileListBox.SelectedIndex = index;
                    プロファイルを編集ToolStripMenuItem.Enabled = true;
                    プロファイルを削除ToolStripMenuItem.Enabled = true;
                    ProfileListContextMenu.Show(ProfileListBox, e.Location);
                }
                else
                {
                    プロファイルを編集ToolStripMenuItem.Enabled = false;
                    プロファイルを削除ToolStripMenuItem.Enabled = false;
                    ProfileListContextMenu.Show(ProfileListBox, e.Location);
                }
            }
        }

        private void プロファイルを追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileListBox.Items.Add(DateTime.Now.ToString());
        }

        private void GeneratePanel_Click(object sender, EventArgs e)
        {
            playerManager.VoiceGenerate("こんにちは");
        }
    }
}
