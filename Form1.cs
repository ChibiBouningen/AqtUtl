﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        bool generated = false;
        
        bool setAquesTalkPlayer = false;
        string last_generated_exo;

        public Form1()
        {
            InitializeComponent();
            GenerateLabel.Parent = GeneratePanel;
            playerManager = new AquesTalkPlayerManager();

            int a;
            a = playerManager.RegistPlayer();
            if (a == 0) setAquesTalkPlayer = true;
            else setAquesTalkPlayer = false;
            
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
            resetGenerated();

            if (serifProfiles.Count <= 0)
            {
                ListAnnaiLabel.Visible = true;
            }
            

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
            resetGenerated();
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
                ListAnnaiLabel.Visible = false;
            }

            f.Dispose();
            ProfileListBoxReload();
            resetGenerated();
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
            resetGenerated();
        }

        private void プロファイルを削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ProfileListBox.SelectedValue.ToString());
            string 項目名 = ProfileListBox.Text;
            int selectId = int.Parse(ProfileListBox.SelectedValue.ToString());
            //MessageBox.Show(selectId.ToString());
            DialogResult result = MessageBox.Show("キャラクタプロファイル「" + 項目名 + "」を削除しようとしています。\n削除しますか？","キャラクタプロファイルの削除", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                serifProfiles.RemoveAll(profile => profile.Id == selectId);
            }

            ProfileListBoxReload();
            resetGenerated();
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
            profileLoader.Save(serifProfiles);
        }

        private void JimakuBox_TextChanged(object sender, EventArgs e)
        {
            if(JimakuCopy_Check.Checked)
            {
                HatsuonBox.Text = JimakuBox.Text;
                resetGenerated();
            }
            
        }

        private void JimakuCopy_Check_Click(object sender, EventArgs e)
        {
            JimakuCopyCheck_reflect();
            resetGenerated();
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

        
        private void GeneratePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(setAquesTalkPlayer)
                {
                    if (generated)
                    {
                        string dragFilePath = last_generated_exo;
                        //File.WriteAllText(dragFilePath, "This is a sample text file.");
                        var dataObject = new DataObject(DataFormats.FileDrop, new string[] { dragFilePath });
                        dataObject.SetData("Preferred DropEffect", new MemoryStream(new byte[] { 5, 0, 0, 0 }));
                        GeneratePanel.DoDragDrop(dataObject, DragDropEffects.Copy);
                    }
                    else
                    {
                        int AviutlFPS = Properties.Settings.Default.fps_AviUtl;

                        if (serifProfiles.Count == 0)
                        {
                            MessageBox.Show("キャラクタプロファイルを作成してください");
                            return;
                        }
                        if (ProfileListBox.SelectedIndex < 0) ProfileListBox.SelectedIndex = 0;
                        

                            GeneratePanel.BackColor = Color.Yellow;
                        last_generated_exo = playerManager.VoiceGenerate(HatsuonBox.Text, JimakuBox.Text, serifProfiles[ProfileListBox.SelectedIndex], AviutlFPS);
                        if (last_generated_exo != "err")
                        {
                            generated = true;
                            GenerateLabel.Text = "ここをD&&Dしてください";
                        }
                        


                        GeneratePanel.BackColor = Color.Gainsboro;
                    }
                }
                else
                {
                    MessageBox.Show("aquestalkplayer/AquesTalkPlayer.exeを配置し\nアプリケーションを再起動してください");
                }
                
                
            }
        }

        void resetGenerated()
        {
            generated = false;
            GenerateLabel.Text = "クリックで音声を生成";
        }

        private void aquesTalkPlayerを起動ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGenerated();
            playerManager.StartupPlayer();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting f = new Setting();
            f.ShowDialog();

            f.Dispose();
        }


        private void aqtUtlを終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aqtUtlについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Overview f = new Overview();
            f.ShowDialog();
        }

        private void HatsuonBox_TextChanged(object sender, EventArgs e)
        {
            resetGenerated();
        }
    }
}
