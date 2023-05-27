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
            sortComboBox.Text = profile.Sort.ToString();
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
        }

        private void MakeProfileButton_Click(object sender, EventArgs e)
        {
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
