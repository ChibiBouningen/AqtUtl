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
        public bool sakusei = false;
        public AddSerifProfile()
        {
            InitializeComponent();
        }

        private void MakeProfileButton_Click(object sender, EventArgs e)
        {
            sakusei = true;
            this.Close();
        }
    }
}
