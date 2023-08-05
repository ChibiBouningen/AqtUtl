﻿using AqT_Utl.Component;
using System;
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
        GcmzAPI_Helper gcmzAPI_Helper;

        bool generated = false;
        bool setAquesTalkPlayer = false;
        int targetProfileIndex = -1;

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
            ProfileListBoxReload();
            ProfileListBox.DisplayMember = "ProfileName";
            ProfileListBox.ValueMember = "Id";

            JimakuCopy_Check.Checked = Properties.Settings.Default.jimakuCopy_startup;
            JimakuCopyCheck_reflect();
            resetGenerated();
            reloadSettings();

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

            targetProfileIndex = ProfileListBox.SelectedIndex;
            resetGenerated();
        }

        private void ProfileListBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }

            Point dragCurrentPoint = new Point(e.X, e.Y);
            int irekaesakiIndex = ProfileListBox.IndexFromPoint(dragCurrentPoint);

            if (targetProfileIndex >= 0 && targetProfileIndex < ProfileListBox.Items.Count && ProfileListBox.SelectedIndex != targetProfileIndex)
            {
                SerifProfile kari = serifProfiles[targetProfileIndex];
                serifProfiles[targetProfileIndex] = serifProfiles[irekaesakiIndex];
                serifProfiles[irekaesakiIndex] = kari;
                targetProfileIndex = ProfileListBox.IndexFromPoint(dragCurrentPoint);
                ProfileListBoxReload();
            }
            
        }

        void ProfileListBoxReload()
        {
            //serifProfiles.Sort((a, b) => b.Sort - a.Sort);
            int i = 0;
            while (i < serifProfiles.Count) //項目のSortをListの並べ順に書き換える
            {
                serifProfiles[i].Sort = i;
                i++;
            }
            ProfileListBox.DataSource = null;
            ProfileListBox.DataSource = serifProfiles;
            profileLoader.Save(serifProfiles);
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

                serifProfiles[selectIndex] = p;

            }
            f.Dispose();
            ProfileListBoxReload();
            resetGenerated();
        }

        private void プロファイルを削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string 項目名 = ProfileListBox.Text;
            int selectId = int.Parse(ProfileListBox.SelectedValue.ToString());
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

        

        private void JimakuBox_TextChanged(object sender, EventArgs e)
        {
            if(JimakuCopy_Check.Checked)
            {
                HatsuonBox.Text = JimakuBox.Text;
            }
        }

        private void HatsuonBox_TextChanged(object sender, EventArgs e)
        {
            resetGenerated();
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

        
        private void GeneratePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(setAquesTalkPlayer)
                {
                    if (generated)
                    {
                        string dragFilePath = last_generated_exo;
                        var dataObject = new DataObject(DataFormats.FileDrop, new string[] { dragFilePath });
                        dataObject.SetData("Preferred DropEffect", new MemoryStream(new byte[] { 5, 0, 0, 0 }));
                        GeneratePanel.DoDragDrop(dataObject, DragDropEffects.Copy);

                        if (Properties.Settings.Default.useGCMZ)
                        {

                            gcmzAPI_Helper.gcmzInsert(last_generated_exo, 0, 100);
                        }
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
                        last_generated_exo = playerManager.VoiceGenerate(HatsuonBox.Text, JimakuBox.Text, serifProfiles[ProfileListBox.SelectedIndex], AviutlFPS, false, Properties.Settings.Default.useGCMZ);
                        if (last_generated_exo != "err")
                        {
                            generated = true;
                            
                            if(Properties.Settings.Default.useGCMZ)
                            {
                                gcmzAPI_Helper.gcmzInsert(last_generated_exo, 0, 100);
                                GenerateLabel.Text = "拡張編集に挿入しました";
                            }
                            else
                            {
                                GenerateLabel.Text = "ここをD&&Dしてください";
                            }
                            
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

        private void PlayPanel_Click(object sender, EventArgs e)
        {
            if(setAquesTalkPlayer)
            {
                if (serifProfiles.Count == 0)
                {
                    MessageBox.Show("キャラクタプロファイルを作成してください");
                    return;
                }
                if (ProfileListBox.SelectedIndex < 0) ProfileListBox.SelectedIndex = 0;
                PlayPanel.BackColor = Color.Yellow;
                //playerManager.VoiceTrialPlay(HatsuonBox.Text, JimakuBox.Text, serifProfiles[ProfileListBox.SelectedIndex]);
                playerManager.VoiceGenerate(HatsuonBox.Text, JimakuBox.Text, serifProfiles[ProfileListBox.SelectedIndex], 30, true, false);
                PlayPanel.BackColor = Color.Gainsboro;
            }
        }

        void resetGenerated()
        {
            generated = false;
            GenerateLabel.Text = "クリックで音声を生成";
        }

        void reloadSettings()
        {
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.useGCMZ)
            {
                if(gcmzAPI_Helper == null) gcmzAPI_Helper = new GcmzAPI_Helper();
                if(gcmzAPI_Helper.gcmzAPIexe_verCheck() == -1)
                {
                    MessageBox.Show("gcmzAPI.exeを配置してください");
                    Properties.Settings.Default.useGCMZ = false;

                    reloadSettings();
                }


                GenerateLabel.Text = "AviUtl拡張編集に挿入";
                Size formsize = this.Size;

                RightSpritContainer.SplitterDistance = this.ClientSize.Height /2;
            }
            else
            {
                GenerateLabel.Text = "クリックで音声を生成";

                RightSpritContainer.SplitterDistance = 0;
            }
            resetGenerated();
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
            reloadSettings();
            
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

        
    }
}
