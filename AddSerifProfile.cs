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
    public partial class AddSerifProfile : Form
    {
        public bool adaptted = false;
        bool editmode;
        SerifProfile profile;
        
        public AddSerifProfile(SerifProfile p, bool edit)
        {
            editmode = edit;
            profile = p;

            Size size = new Size(514, 443);

            this.MaximumSize = size;
            this.MinimumSize = size;

            InitializeComponent();
        }

        private void AddSerifProfile_Load(object sender, EventArgs e)
        {
            if (editmode)
            {
                MakeProfileButton.Text = "適用";
            }
            else
            {
                MakeProfileButton.Text = "作成";
            }

            ProfileNameBox.Text = profile.ProfileName;
            AquesPresetNameBox.Text = profile.UsePreset;
            LayerBox.Text = profile.layer.ToString();
            jimakuCheck.Checked = profile.Jimaku;
            exoBox.Text = profile.Exo;
            HoseiBox.Text = profile.Hosei.ToString();

            if(jimakuCheck.Checked)
            {
                exoLabel.Enabled = true;
                exoBox.Enabled = true;
            }
            else
            {
                exoLabel.Enabled = false;
                exoBox.Enabled = false;
            }

            KaisetsuTip.SetToolTip(label1, "プロファイルの名前を設定します。");
            KaisetsuTip.SetToolTip(ProfileNameBox, "プロファイルの名前を設定します。");
            KaisetsuTip.SetToolTip(label2, "AquesTalkPlayerで設定したプリセット名を設定します");
            KaisetsuTip.SetToolTip(AquesPresetNameBox, "AquesTalkPlayerで設定したプリセット名を設定します。");
            KaisetsuTip.SetToolTip(label3, "拡張編集に追加するオブジェクトの長さを入力フレーム数分延長します。");
            KaisetsuTip.SetToolTip(HoseiBox, "拡張編集に追加するオブジェクトの長さを入力フレーム数分延長します。");
            KaisetsuTip.SetToolTip(label4, "音声が追加されるレイヤーを指定します。この設定はごちゃまぜドロップスとの連携設定を行っていない場合は機能しません。");
            KaisetsuTip.SetToolTip(LayerBox, "音声が追加されるレイヤーを指定します。この設定はごちゃまぜドロップスとの連携設定を行っていない場合は機能しません。");
            KaisetsuTip.SetToolTip(jimakuCheck, "字幕設定を有効化します。詳細は配布ページにある解説をご確認ください。");
            KaisetsuTip.SetToolTip(exoBox, "exoファイルを編集後ここに貼り付けます。詳細は配布ページにある解説をご確認ください。");
        }

        private void MakeProfileButton_Click(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(HoseiBox.Text, out i) == false)
            {
                MessageBox.Show("音声の長さ補正には半角で整数値を入力してください。");
                HoseiBox.Focus();
                return;
            }
            if (int.TryParse(LayerBox.Text, out i) == false)
            {
                MessageBox.Show("挿入するレイヤーには半角で整数値を入力してください。");
                LayerBox.Focus();
                return;
            }

            adaptted = true;
            this.Close();
        }

        private void jimakuCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (jimakuCheck.Checked)
            {
                exoLabel.Enabled = true;
                exoBox.Enabled = true;
            }
            else
            {
                exoLabel.Enabled = false;
                exoBox.Enabled = false;
            }
        }
    }
}
