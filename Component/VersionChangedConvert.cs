using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl.Component
{
    internal class VersionChangedConvert
    {
        public VersionChangedConvert(Version last_version)
        {
            //ここにバージョン変更時の処理を書くかもしれない
            MessageBox.Show("前回起動時からバージョンが変更されました。");
        }
    }
}
