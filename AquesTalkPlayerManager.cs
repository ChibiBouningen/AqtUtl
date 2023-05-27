﻿using System;
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
                //MessageBox.Show(PlayerPath);
            }
            else
            {
                //MessageBox.Show("なし");
            }
            return 0;
        }

        public int VoiceGenerate(string text)
        {
            string output_folder;
            if (Properties.Settings.Default.output_folder == "output")
            {
                //output_folder = 
            }
            


            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = PlayerPath;
            processStartInfo.Arguments = "/T \"" + text + "\"";

            Process process = Process.Start(processStartInfo);

            process.WaitForExit();

            return 0;
        }
    }
}
