using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl.Component
{
    internal class VersionChangedConvert
    {
        public VersionChangedConvert(Version last_version)
        {
            Version now = Assembly.GetExecutingAssembly().GetName().Version;

            //ここにバージョン変更時の処理を書くかもしれない
            //MessageBox.Show("前回起動時からバージョンが変更されました。");\
            if (now > last_version)
            {
                MessageBox.Show("AqtUtlが更新されました。\nv" + last_version + " -> v" + now);
            }
            else if(now < last_version)
            {
                MessageBox.Show("AqtUtlのバージョンが古いものに置き換えられました。\nv" + last_version + " -> v" + now);
            }
        }
    }
}
