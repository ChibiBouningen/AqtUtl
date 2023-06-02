using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl
{
    internal class GCMZdropsManager
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        public const Int32 WM_COPYDATA = 0x004A;


        [StructLayout(LayoutKind.Sequential)]
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
            //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            //public string ProjectPath;
            //ushort[] ProjectPath;
            public uint Flags;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public uint cbData;
            //[MarshalAs(UnmanagedType.LPWStr)]
            public IntPtr lpData;
        }

        public struct SendJSON
        {
            public int layer { get; set; }
            public int frameAdvance { get; set; }
            public string files { get; set; }
        }

        Mutex hMutex;
        MemoryMappedFile hFMO;
        GCMZDropsData p;

        public GCMZdropsManager()
        {

            
            
        }

        public string linkGCMZ()
        {
            try
            {
                hMutex = Mutex.OpenExisting("GCMZDropsMutex");
            }
            catch
            {
                return "NotFoundGCMZ";
            }

            try
            {
                hFMO = MemoryMappedFile.OpenExisting("GCMZDrops");
            }
            catch
            {
                return "MissingOpenFileMapping";
            }

            MemoryMappedViewAccessor accessor = hFMO.CreateViewAccessor();
            accessor.Read(0, out p);

            IntPtr targetWnd = (IntPtr)(ulong)p.Window;

            if (targetWnd == null) return "MissingCatchedWindow";
            if (p.Width == 0) return "NotOpenProject";
            if (p.GCMZAPIVer == 0) return "oldVerGCMZ";

            IntPtr myWnd = Process.GetCurrentProcess().Handle;
            COPYDATASTRUCT cds;

            cds.dwData = (IntPtr)1;

            SendJSON sendJSON = new SendJSON
            {
                layer = 1,
                frameAdvance = 100,
                //files = "D:\\録音データ\\2020_0525_11-00-16.wav"
                files = "D:\\録音データ\\2020_0525_11-00-15.wav"
            };

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                //Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create()
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            };

            string makeLPDATA = JsonSerializer.Serialize(sendJSON, options);
            MessageBox.Show(makeLPDATA);

            cds.dwData = IntPtr.Zero;
            cds.lpData = Marshal.StringToHGlobalUni(makeLPDATA);
            cds.cbData = (uint)((makeLPDATA.Length + 1) * 2);

            IntPtr pnt = Marshal.AllocHGlobal(Marshal.SizeOf(cds));
            Marshal.StructureToPtr(cds, pnt, false);

            //byte[] jsonBytes = Encoding.UTF8.GetBytes(cds.lpData);
            //IntPtr jsonPtr = Marshal.AllocHGlobal(cds.lpData.Length);
            //Marshal.Copy(jsonBytes,0,jsonPtr,cds.lpData.Length);

            //SendMessage((int)targetWnd, WM_COPYDATA, (int)myWnd, ref cds);
            //SendMessage(targetWnd, WM_COPYDATA, IntPtr.Zero, ref cds);
            SendMessage(targetWnd, WM_COPYDATA, myWnd, pnt);


            return "success";
        }

        public void CloseHandle()
        {
            //hMutex.Dispose();
            //hFMO.Dispose();
        }
    }
}
