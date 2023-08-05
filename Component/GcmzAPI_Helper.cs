using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl.Component
{
    internal class GcmzAPI_Helper
    {
        public string gcmzAPIexe_Path;
        int gcmzAPIexe_version;
        public GcmzAPI_Helper()
        {
            
        }

        public int gcmzAPIexe_verCheck()
        {
            if (File.Exists("gcmzAPI.exe"))
            {
                gcmzAPIexe_Path = Path.GetFullPath("gcmzAPI.exe");
                ProcessStartInfo verCheckInfo = new ProcessStartInfo();
                verCheckInfo.FileName = gcmzAPIexe_Path;
                verCheckInfo.CreateNoWindow = true;
                verCheckInfo.UseShellExecute = false;
                verCheckInfo.Arguments = "-v";

                Process verCheckProcess = Process.Start(verCheckInfo);
                verCheckProcess.WaitForExit();
                gcmzAPIexe_version = verCheckProcess.ExitCode;


            }
            else
            {
                gcmzAPIexe_Path = "none";
                gcmzAPIexe_version = -1;
            }

            return gcmzAPIexe_version;
        }

        public int gcmzInsert(string exopath, int layer) //ごちゃまぜドロップス外部連携APIとgcmzAPI.exeでexoファイルを拡張編集に投げる
        {
            if (gcmzAPIexe_verCheck() == -1)    //gcmzAPI.exeが存在しない場合
            {
                return -1;
            }

            string[] exoLines = File.ReadAllLines(exopath);     //exoファイルからendの値を出す
            string pattern = @"^end=(\d+)$";
            Regex regex = new Regex(pattern);

            int moveframe = 0;

            foreach (string line in exoLines)
            {
                Match match = regex.Match(line);
                if (match.Success)
                {
                    string endStr = match.Groups[1].Value;
                    if(int.TryParse(endStr, out int end))
                    {
                        moveframe = end;    //一番上にあるend=値の値をmoveframeに代入してループから抜ける
                        break;
                    }
                }
            }


            string sendPath = exopath.Replace(@"\", "\\\\\\\\");

            ProcessStartInfo insertInfo = new ProcessStartInfo();
            insertInfo.FileName = gcmzAPIexe_Path;
            insertInfo.CreateNoWindow = true;
            insertInfo.UseShellExecute = false;
            insertInfo.Arguments = "-f " + sendPath + " -l " + layer + " -a " + moveframe;

            Process insertProcess = Process.Start(insertInfo);

            insertProcess.WaitForExit();

            int exitCode = insertProcess.ExitCode;
            switch(exitCode)
            {
                case 122:
                case 123:
                    MessageBox.Show("ごちゃまぜドロップスへのアクセスに失敗しました");
                    return 1;
                default:
                    break;
            }

            return 0;
        }
    }
}
