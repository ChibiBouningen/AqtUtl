using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AqT_Utl
{
    internal class AquesTalkPlayerManager
    {
        string PlayerPath;
        public AquesTalkPlayerManager()
        {

        }

        public int RegistPlayer()
        {
            if(File.Exists("aquestalkplayer/AquesTalkPlayer.exe"))
            {
                PlayerPath = Path.GetFullPath("aquestalkplayer/AquesTalkPlayer.exe");
            }
            else
            {
                //MessageBox.Show("なし");
            }
            return 0;
        }

        public int VoiceGenerate(string text)
        {
            string output_folder = "output";
            if (Properties.Settings.Default.output_folder == "output")
            {
                if(Directory.Exists("output") == false)
                {
                    Directory.CreateDirectory("output");
                    
                }
                output_folder = Path.GetFullPath("output");

            }
            else
            {
                if(Directory.Exists(Properties.Settings.Default.output_folder))
                {
                    output_folder = Properties.Settings.Default.output_folder;
                }
                else
                {
                    MessageBox.Show("ボイス生成フォルダの設定が正しくありません。");
                    return 1;
                }
            }

            Random random = new Random();
            string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + random.Next(1000,9999) + ".wav";

            string filepath = output_folder + "\\" + filename;

            string 引数 = "/T \"" + text + "\" " + "/F \"" + filepath + "\"";


            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = PlayerPath;
            processStartInfo.Arguments = 引数;

            Process process = Process.Start(processStartInfo);

            process.WaitForExit();

            return 0;
        }
    }
}
