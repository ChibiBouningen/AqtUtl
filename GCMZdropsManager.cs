using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl
{
    internal class GCMZdropsManager
    {
        //[StructLayout(LayoutKind.Sequential)]
        struct GCMZDropsData
        {
            public uint Window;
            public int Width;
            public int Height;
            public int VideoRate;
            public int VideoScale;
            public int AudioRate;
            public int AudioCh;
            public int GCMZAPIVer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string ProjectPath;
            public uint Flags;
        }

        public bool can_useGCMZ = false;
        Mutex hMutex;
        MemoryMappedFile hFMO;
        GCMZDropsData p;

        public GCMZdropsManager()
        {
            
            try
            {
                hMutex = Mutex.OpenExisting("GCMZDropsMutex");
                hFMO = MemoryMappedFile.OpenExisting("GCMZDrops");
                MemoryMappedViewAccessor accessor = hFMO.CreateViewAccessor();
                accessor.Read(0, out p);
                hMutex.WaitOne();
                IntPtr targetWnd = (IntPtr)(ulong)p.Window;
                //インスタンスを使いまわさず、音声生成のたびに作り直すようにする

                can_useGCMZ = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);
            }
            
        }

        public void CloseHandle()
        {
            //hMutex.Dispose();
            //hFMO.Dispose();
        }
    }
}
