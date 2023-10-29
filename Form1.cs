using AqT_Utl.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AqT_Utl
{
    public partial class Form1 : Form
    {
        List<SerifProfile> serifProfiles;
        AquesTalkPlayerManager playerManager;
        SettingLoader settingLoader;
        ProfileLoader profileLoader;
        GcmzAPI_Helper gcmzAPI_Helper;
        GcmzAPI gcmzAPI;

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

            settingLoader = new SettingLoader();
            profileLoader = new ProfileLoader();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += "   v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            settingLoader.Load();       //設定をjsonから読み込み
            profileLoader.Load(ref serifProfiles);  //プロファイルをjsonから読み込み

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

            KaisetsuTip.SetToolTip(ProfileListBox, "右クリックでプロファイルの作成や編集ができます。");
            KaisetsuTip.SetToolTip(JimakuCopy_Check, "発音記号を字幕に合わせます。");
            KaisetsuTip.SetToolTip(PlayPanel, "クリックで音声を試聴します。ファイルには保存されません。");

            this.DoubleBuffered = true;     //Formのダブルバッファリングを有効化

        }


        private void ProfileListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = ProfileListBox.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    ProfileListBox.SelectedIndex = index;
                    プロファイルを複製ToolStripMenuItem.Visible = true;
                    プロファイルを編集ToolStripMenuItem.Visible = true;
                    プロファイルを削除ToolStripMenuItem.Visible = true;
                    ProfileListContextMenu.Show(ProfileListBox, e.Location);
                }
                else
                {
                    プロファイルを複製ToolStripMenuItem.Visible = false;
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

            if (targetProfileIndex >= 0 && targetProfileIndex < ProfileListBox.Items.Count && ProfileListBox.SelectedIndex != targetProfileIndex  && irekaesakiIndex >= 0)
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
                //p.Sort = int.Parse(f.sortComboBox.Text);
                p.Jimaku = f.jimakuCheck.Checked;
                p.Exo = f.exoBox.Text;
                p.Hosei = int.Parse(f.HoseiBox.Text);
                p.layer = int.Parse(f.LayerBox.Text);

                Random random = new Random();
                p.Id = random.Next();

                serifProfiles.Add(p);
                ListAnnaiLabel.Visible = false;
            }

            f.Dispose();
            ProfileListBoxReload();
            resetGenerated();
        }

        private void プロファイルを複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectId = int.Parse(ProfileListBox.SelectedValue.ToString());
            int selectIndex = ProfileListBox.SelectedIndex;
            
            //選択されているProfileをディープコピー
            string serializedInstance = JsonSerializer.Serialize(serifProfiles.Find(x => x.Id == selectId));
            SerifProfile p = JsonSerializer.Deserialize<SerifProfile>(serializedInstance);

            Random random = new Random();
            p.Id = random.Next();
            p.ProfileName += "_copy";
            serifProfiles.Add(p);
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
                //p.Sort = int.Parse(f.sortComboBox.Text);
                p.Jimaku = f.jimakuCheck.Checked;
                p.Exo = f.exoBox.Text;
                p.Hosei = int.Parse(f.HoseiBox.Text);
                p.layer = int.Parse(f.LayerBox.Text);

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
            DialogResult result = MessageBox.Show("プロファイル「" + 項目名 + "」を削除しようとしています。\n削除しますか？","プロファイルの削除", MessageBoxButtons.YesNo);
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
            resetGenerated();
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

        
        private void GeneratePanel_MouseDown(object sender, MouseEventArgs e)   //生成パネルでマウスを押下
        {
            if(e.Button == MouseButtons.Left)
            {
                generate(false);
            }
        }

        private void generate(bool useShortcutKey)
        {
            if (setAquesTalkPlayer)
            {
                if (generated)      //生成済みの場合
                {
                    //ドラッグアンドドロップ開始処理
                    if(!useShortcutKey)
                    {
                        string dragFilePath = last_generated_exo;
                        var dataObject = new DataObject(DataFormats.FileDrop, new string[] { dragFilePath });
                        dataObject.SetData("Preferred DropEffect", new MemoryStream(new byte[] { 5, 0, 0, 0 }));
                        GeneratePanel.DoDragDrop(dataObject, DragDropEffects.Copy);
                    }
                    

                    if (Properties.Settings.Default.useGCMZ)    //GCMZモード有効時
                    {
                        Point cursorPosition = Control.MousePosition;
                        if(this.Bounds.Contains(cursorPosition) || useShortcutKey)
                        {
                            int returnCode = gcmzAPI.gcmzInsert(last_generated_exo, serifProfiles[ProfileListBox.SelectedIndex].layer);
                            if (returnCode == 0)
                            {
                                GenerateLabel.Text = "拡張編集に挿入しました";
                            }
                            else
                            {
                                MessageBox.Show("挿入に失敗しました。\nエラーコード " + returnCode);
                            }
                        }

                    }
                }
                else
                {                //未生成の場合
                    int AviutlFPS = Properties.Settings.Default.fps_AviUtl;

                    if (serifProfiles.Count == 0)
                    {
                        MessageBox.Show("プロファイルを作成してください");
                        return;
                    }
                    if (ProfileListBox.SelectedIndex < 0) ProfileListBox.SelectedIndex = 0;

                    GeneratePanel.BackColor = Color.Yellow;
                    last_generated_exo = playerManager.VoiceGenerate(HatsuonBox.Text, JimakuBox.Text, serifProfiles[ProfileListBox.SelectedIndex], AviutlFPS, false, Properties.Settings.Default.useGCMZ);
                    if (last_generated_exo != "err")    //生成できた場合
                    {
                        generated = true;

                        if (Properties.Settings.Default.useGCMZ) //GCMZモード有効時
                        {
                            generate(useShortcutKey);
                            
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

        private void PlayPanel_Click(object sender, EventArgs e)    //再生パネルをクリック
        {
            if(setAquesTalkPlayer)
            {
                if (serifProfiles.Count == 0)
                {
                    MessageBox.Show("プロファイルを作成してください");
                    return;
                }
                if (ProfileListBox.SelectedIndex < 0) ProfileListBox.SelectedIndex = 0; //もしプロファイルが選択されていなければ、一番上のプロファイルを選択
                PlayPanel.BackColor = Color.Yellow;
                playerManager.VoiceGenerate(HatsuonBox.Text, JimakuBox.Text, serifProfiles[ProfileListBox.SelectedIndex], 30, true, false); //仮モード、音声再生有効で生成
                PlayPanel.BackColor = Color.Gainsboro;
            }
        }

        void resetGenerated()   //生成リセット
        {
            generated = false;
            if(Properties.Settings.Default.useGCMZ) //GCMZモード有効時
            {
                GenerateLabel.Text = "拡張編集に挿入(Ctrl + Insert)";
            }
            else
            {
                GenerateLabel.Text = "音声を生成(Ctrl + Insert)";
            }
        }

        void reloadSettings()   //設定読み込み＆反映
        {
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.useGCMZ)
            {
                if(gcmzAPI == null) gcmzAPI = new GcmzAPI();


                GenerateLabel.Text = "AviUtlに挿入(Ctrl + Insert)";
                Size formsize = this.Size;

                RightSpritContainer.SplitterDistance = this.ClientSize.Height /2;
                RightSpritContainer.IsSplitterFixed = false;
            }
            else
            {
                GenerateLabel.Text = "音声を生成(Ctrl + Insert)";

                RightSpritContainer.SplitterDistance = 0;
                RightSpritContainer.IsSplitterFixed = true;
            }
            this.TopMost = Properties.Settings.Default.TopMost;

            settingLoader.Save();

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

        private void GenerateLabel_TextChanged(object sender, EventArgs e)      //生成ラベルの内容が変化したときに中央に寄せる処理
        {
            int x = (GeneratePanel.Width - GenerateLabel.Width) / 2;
            int y = (GeneratePanel.Height - GenerateLabel.Height) / 2;
            GenerateLabel.Location = new Point(x, y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)       //ショートカットイベントを記述
        {
            if(e.KeyData == (Keys.Control | Keys.Insert))
            {
                generate(true);
            }
            if(e.KeyData == Keys.F5)
            {
                object kariObject = new object();
                EventArgs kariEventArgs = new EventArgs();
                PlayPanel_Click(kariObject, kariEventArgs);
            }
            
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)    //Form標準のと重複するショートカットイベントはこっちに記述
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.I))   //Ctrl + Shift + O
            {
                if (ProfileListBox.SelectedIndex > 0)
                {
                    ProfileListBox.SelectedIndex = ProfileListBox.SelectedIndex - 1;
                    
                }
                return true;
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.K))  //Ctrl + Shift + L
            {
                if (ProfileListBox.SelectedIndex < ProfileListBox.Items.Count - 1)
                {
                    ProfileListBox.SelectedIndex = ProfileListBox.SelectedIndex + 1;
                    
                }
                return true;
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.O))    //字幕ボックスにフォーカス
            {
                JimakuBox.Focus();
                return true;
            }
            if (keyData == (Keys.Control| Keys.Shift | Keys.L))     //発音ボックスにフォーカスして字幕コピーモード有効化
            {
                HatsuonBox.Focus();
                JimakuCopy_Check.Checked = false;
                JimakuCopyCheck_reflect();
                return true;
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.M))  //Ctrl + Shift + M
            {
                JimakuCopy_Check.Checked = !JimakuCopy_Check.Checked;
                JimakuCopyCheck_reflect();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
