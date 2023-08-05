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

        public void StartupPlayer()
        {
            try
            {
                Process.Start(PlayerPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show("aquestalkplayer/AquesTalkPlayer.exeが見つかりません");
            }
            
        }

        public string VoiceGenerate(string hatsuon, string jimaku, SerifProfile p, int fps, bool interim, bool OffSound)   //音声を生成
        {

            fps = Properties.Settings.Default.fps_AviUtl;
            string output_folder = "output";

            if (hatsuon == "") hatsuon = "_"; //発音なしの場合発音しない適当な文字に置換

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
                    return "err";
                }
            }

            Random random = new Random();
            string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + random.Next(1000,9999);

            string filepath = output_folder + "\\" + filename + ".wav";

            string 引数 = "/T \"" + hatsuon + "\" " + "/P \"" + p.UsePreset + "\" " + "/W \"" + filepath + "\"";


            ProcessStartInfo GenerateProcessStartInfo = new ProcessStartInfo();
            GenerateProcessStartInfo.FileName = PlayerPath;
            GenerateProcessStartInfo.Arguments = 引数;

            ProcessStartInfo ListenProcessStartInfo = new ProcessStartInfo();
            ListenProcessStartInfo.FileName = PlayerPath;
            ListenProcessStartInfo.Arguments = "/T \"" + hatsuon + "\"" + "/P \"" + p.UsePreset + "\"";

            Process voiceGenerate = Process.Start(GenerateProcessStartInfo);
            if (OffSound == false)
            {
                Process voiceListen = Process.Start(ListenProcessStartInfo);
            }

            voiceGenerate.WaitForExit();



            //フレーム数を求める
            int frameCount = 0;
            try
            {
                using (var reader = new WaveFileReader(filepath))
                {
                    double duration = reader.TotalTime.TotalSeconds;
                    frameCount = (int)(duration * fps);
                    Console.WriteLine("wavファイルの長さ: {0:F2}秒", duration);
                    Console.WriteLine("動画編集ソフトに読み込む際に必要なフレーム数: {0}", frameCount);
                }
            }
            catch
            {
                MessageBox.Show("音声ファイルの生成に失敗しました。");
                return "err";
            }


            if (interim)    //仮モード有効時、生成した音声ファイルを削除し終了する
            {
                string wavfilepath = output_folder + "\\" + filename + ".wav";
                File.Delete(wavfilepath);
                return "delete_success";
            }

            frameCount += p.Hosei;

            ExoGenerate exoGenerate = new ExoGenerate();
            exoGenerate.make_exo(p, jimaku, filepath, frameCount, output_folder + "\\" + filename + ".exo");

            return output_folder + "\\" + filename + ".exo";
        }

    }
}
