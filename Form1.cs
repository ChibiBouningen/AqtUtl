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
            //ProfileListBox.DataSource = serifProfiles;
            ProfileListBoxReload();
            ProfileListBox.DisplayMember = "ProfileName";
            ProfileListBox.ValueMember = "Id";

            JimakuCopy_Check.Checked = Properties.Settings.Default.jimakuCopy_startup;
            JimakuCopyCheck_reflect();
            
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
            SerifProfile p = new SerifProfile();
            AddSerifProfile f = new AddSerifProfile(p, false);
            
            f.ShowDialog();
            if(f.adaptted)
            {
                p.ProfileName = f.ProfileNameBox.Text;
                p.UsePreset = f.AquesPresetNameBox.Text;
                p.Sort = int.Parse(f.sortComboBox.Text);
                p.Jimaku = f.jimakuCheck.Checked;
                p.Exo = f.exoBox.Text;
                p.Hosei = int.Parse(f.HoseiBox.Text);

                Random random = new Random();
                p.Id = random.Next();

                serifProfiles.Add(p);
            }

            f.Dispose();
            ProfileListBoxReload();
        }

        private void プロファイルを編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectId = int.Parse(ProfileListBox.SelectedValue.ToString());
            int selectIndex = ProfileListBox.SelectedIndex;
            SerifProfile p = new SerifProfile();
            p = serifProfiles.Find(x => x.Id == selectId);
            AddSerifProfile f = new AddSerifProfile(p, true);
            f.ShowDialog();
            if (f.adaptted)
            {
                p.ProfileName = f.ProfileNameBox.Text;
                p.UsePreset = f.AquesPresetNameBox.Text;
                p.Sort = int.Parse(f.sortComboBox.Text);
                p.Jimaku = f.jimakuCheck.Checked;
                p.Exo = f.exoBox.Text;
                p.Hosei = int.Parse(f.HoseiBox.Text);

                /*serifProfiles.RemoveAll(profile => profile.Id == selectId);
                serifProfiles.Add(p);*/
                serifProfiles[selectIndex] = p;

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
    

        private void GeneratePanel_Click(object sender, EventArgs e)
        {
            int AviutlFPS = Properties.Settings.Default.fps_AviUtl;
            GeneratePanel.BackColor = Color.Yellow;
            try
            {
                playerManager.VoiceGenerate(HatsuonBox.Text, JimakuBox.Text, serifProfiles[ProfileListBox.SelectedIndex], AviutlFPS);
            }
            catch
            {

            }
            
            GeneratePanel.BackColor = Color.Gainsboro;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            profileLoader.Save(serifProfiles);
        }

        void ProfileListBoxReload()
        {
            serifProfiles.Sort((a, b) => b.Sort - a.Sort);
            ProfileListBox.DataSource = null;
            ProfileListBox.DataSource = serifProfiles;
        }

        private void JimakuBox_TextChanged(object sender, EventArgs e)
        {
            if(JimakuCopy_Check.Checked)
            HatsuonBox.Text = JimakuBox.Text;
        }

        private void JimakuCopy_Check_Click(object sender, EventArgs e)
        {
            JimakuCopyCheck_reflect();
        }

        void JimakuCopyCheck_reflect()
        {
            if (JimakuCopy_Check.Checked)
            {
                HatsuonBox.ReadOnly = true;
            }
            else
            {
                HatsuonBox.ReadOnly = false;
            }
            HatsuonBox.Text = JimakuBox.Text;
        }

        private void GeneratePanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            e.Effect = DragDropEffects.Copy;
        }
    }
}
