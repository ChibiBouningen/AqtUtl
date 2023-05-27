using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using NAudio.Wave;

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
                return 0;
            }
            else
            {
                //MessageBox.Show("なし");
                return 1;
            }
            
        }

        public int VoiceGenerate(string text)
        {
            int fps = 60;
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

            string 引数 = "/T \"" + text + "\" " + "/W \"" + filepath + "\"";


            ProcessStartInfo GenerateProcessStartInfo = new ProcessStartInfo();
            GenerateProcessStartInfo.FileName = PlayerPath;
            GenerateProcessStartInfo.Arguments = 引数;

            ProcessStartInfo ListenProcessStartInfo = new ProcessStartInfo();
            ListenProcessStartInfo.FileName = PlayerPath;
            ListenProcessStartInfo.Arguments = "/T \"" + text + "\"";

            Process voiceGenerate = Process.Start(GenerateProcessStartInfo);
            Process voiceListen = Process.Start(ListenProcessStartInfo);

            voiceGenerate.WaitForExit();

            

            //フレーム数を求める

            using (var reader = new WaveFileReader(filepath))
            {
                double duration = reader.TotalTime.TotalSeconds;
                int frameCount = (int)(duration * fps);
                Console.WriteLine("wavファイルの長さ: {0:F2}秒", duration);
                Console.WriteLine("動画編集ソフトに読み込む際に必要なフレーム数: {0}", frameCount);
            }

            return 0;
        }
    }
}
