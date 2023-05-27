using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AqT_Utl
{
    public partial class Form1 : Form
    {
        List<SerifProfile> serifProfiles;
        AquesTalkPlayerManager playerManager;
        ProfileLoader profileLoader;

        public Form1()
        {
            InitializeComponent();
            GenerateLabel.Parent = GeneratePanel;
            playerManager = new AquesTalkPlayerManager();
            playerManager.RegistPlayer();
            profileLoader = new ProfileLoader();
            profileLoader.Load(ref serifProfiles);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProfileListBox.DataSource = serifProfiles;
            ProfileListBox.DisplayMember = "ProfileName";
            ProfileListBox.ValueMember = "Id";
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
                    プロファイルを編集ToolStripMenuItem.Visible = true;
                    プロファイルを削除ToolStripMenuItem.Visible = true;
                    ProfileListContextMenu.Show(ProfileListBox, e.Location);
                }
                else
                {
                    プロファイルを編集ToolStripMenuItem.Visible = false;
                    プロファイルを削除ToolStripMenuItem.Visible = false;
                    ProfileListContextMenu.Show(ProfileListBox, e.Location);
                }
            }
        }

        private void プロファイルを追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSerifProfile f = new AddSerifProfile();
            SerifProfile p = new SerifProfile();
            f.ShowDialog();
            try
            {
                p.ProfileName = f.ProfileNameBox.Text;

                Random random = new Random();
                //p.Id = int.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
                p.Id = random.Next();

                serifProfiles.Add(p);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            f.Dispose();
            ProfileListBoxReload();
        }

        private void プロファイルを削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ProfileListBox.SelectedValue.ToString());
            string 項目名 = ProfileListBox.Text;
            int selectId = int.Parse(ProfileListBox.SelectedValue.ToString());
            //MessageBox.Show(selectId.ToString());
            DialogResult result = MessageBox.Show("キャラクタ プロファイル「" + 項目名 + "」を削除しようとしています。\n削除しますか？","キャラクタ プロファイルの削除", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                serifProfiles.RemoveAll(profile => profile.Id == selectId);
            }

            ProfileListBoxReload();
        }

        void ProfileListBoxReload()
        {
            ProfileListBox.DataSource = null;
            ProfileListBox.DataSource = serifProfiles;
        }

        private void GeneratePanel_Click(object sender, EventArgs e)
        {
            playerManager.VoiceGenerate("こんにちは");
        }

        
    }
}
