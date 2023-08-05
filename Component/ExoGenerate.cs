using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl
{
    internal class ExoGenerate
    {
        public void make_exo(SerifProfile p, string jimaku, string wavpath, int frame, string exoFilePath)
        {

            jimaku = ConvertExoText(jimaku);

            string exo = p.Exo;
            if(p.Jimaku == false)
            {
                exo = "[0]\r\nstart=1\r\nend={2}\r\nlayer=1\r\noverlay=1\r\naudio=1\r\n[0.0]\r\n_name=音声ファイル\r\n再生位置=0.00\r\n再生速度=100.0\r\nループ再生=0\r\n動画ファイルと連携=0\r\nfile={1}\r\n[0.1]\r\n_name=標準再生\r\n音量=100.0\r\n左右=0.0";

            }

            exo = exo.Replace("{0}", jimaku);
            exo = exo.Replace("{1}", wavpath);
            exo = exo.Replace("{2}", frame.ToString());


            StreamWriter sw = new StreamWriter(exoFilePath, false, System.Text.Encoding.GetEncoding("shift_jis"));
            sw.WriteLine(exo);
            sw.Close();
        }


        private string ConvertExoText(string text)  //https://qiita.com/R_TES_/items/57ad42b7b66882c39797 R_TES_様のこちらのコードをそのまま使わせていただきました。ありがとうございます。
        {
            string result = BitConverter.ToString(UnicodeEncoding.Unicode.GetBytes(text)).Replace("-", "");
            result = result + new string('0', 4096 - result.Length);
            return result;
        }

    }
}
