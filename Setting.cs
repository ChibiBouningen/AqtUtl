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
            GCMZcheck.Checked = Properties.Settings.Default.useGCMZ;
            TopMostCheck.Checked = Properties.Settings.Default.TopMost;

            KaisetsuTip.SetToolTip(label1, "音声出力先のフォルダパスを指定します。\\から書き始めると相対パスで指定されます。");
            KaisetsuTip.SetToolTip(output_folderBox, "音声出力先のフォルダパスを指定します。\\から書き始めると相対パスで指定されます。");
            KaisetsuTip.SetToolTip(label2, "AviUtlのプロジェクトのフレームレートを指定します。");
            KaisetsuTip.SetToolTip(FPScomboBox, "AviUtlのプロジェクトのフレームレートを指定します。");
            KaisetsuTip.SetToolTip(JimakuCheck, "チェックを入れると、AqtUtlの起動時に「字幕をコピー」にチェックが入ります。");
            KaisetsuTip.SetToolTip(GCMZcheck, "ごちゃまぜドロップスと連携し、1クリック挿入機能を有効にします。\nAviUtlにプラグイン「ごちゃまぜドロップス」を導入している必要があります。");
            KaisetsuTip.SetToolTip(TopMostCheck, "AqtUtlのウィンドウを常に最前面に表示するようになります。");
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
            Properties.Settings.Default.useGCMZ = GCMZcheck.Checked;
            Properties.Settings.Default.TopMost = TopMostCheck.Checked;
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            output_folderBox.Text = Properties.Settings.Default.output_folder;
            FPScomboBox.Text = Properties.Settings.Default.fps_AviUtl.ToString();
            JimakuCheck.Checked = Properties.Settings.Default.jimakuCopy_startup;
            GCMZcheck.Checked = Properties.Settings.Default.useGCMZ;
            TopMostCheck.Checked = Properties.Settings.Default.TopMost;
        }
    }
}
