using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AqT_Utl.Component
{
    internal class GcmzAPI
    {

        //ごちゃまぜドロップス作者様のC#使用例を参照させていただきました https://gist.github.com/oov/fc81cea1bf1bd0500f92ac0599cc0edd

        const uint MUTEX_ALL_ACCESS = 0x1F0001;
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern SafeWaitHandle OpenMutex(
            uint dwDesiredAccess,
            [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
            string lpName);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReleaseMutex(SafeWaitHandle hMutex);
        const UInt32 INFINITE = 0xFFFFFFFF;
        const UInt32 WAIT_FAILED = 0xFFFFFFFF;
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern UInt32 WaitForSingleObject(SafeWaitHandle hHandle, UInt32 dwMilliseconds);
        const uint FILE_MAP_READ = 0x00000004;
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern SafeMemoryMappedFileHandle OpenFileMapping(
            uint dwDesiredAccess,
            [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
            string lpName);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr MapViewOfFile(
           SafeMemoryMappedFileHandle hFileMappingObject,
           uint dwDesiredAccess,
           uint dwFileOffsetHigh,
           uint dwFileOffsetLow,
           UIntPtr dwNumberOfBytesToMap);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);
        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            IntPtr wParam,
            [MarshalAs(UnmanagedType.LPStruct), In] COPYDATASTRUCT lParam);
        const int WM_COPYDATA = 0x004A;

        [StructLayout(LayoutKind.Sequential)]
        internal class COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            public IntPtr lpData;
        }
        const int MAX_PATH = 260;
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
        internal class GCMZDropsData
        {
            public UInt32 Window;
            public Int32 Width;
            public Int32 Height;
            public Int32 VideoRate;
            public Int32 VideoScale;
            public Int32 AudioRate;
            public Int32 AudioCh;
            public Int32 GCMZAPIVer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string ProjectPath;
        }

        public GcmzAPI()
        {

        }



        public int gcmzInsert(string exopath, int layer)
        {
            var mtx = OpenMutex(MUTEX_ALL_ACCESS, false, "GCMZDropsMutex");
            if (mtx.IsInvalid)
            {
                Console.WriteLine("failed to open mutex");
                return 1022;
            }
            var fmo = OpenFileMapping(FILE_MAP_READ, false, "GCMZDrops");
            if (fmo.IsInvalid)
            {
                Console.WriteLine("failed to open file mapping object");
                return 1023;
            }
            var mapped = MapViewOfFile(fmo, FILE_MAP_READ, 0, 0, (UIntPtr)0);
            if (mapped == null)
            {
                Console.WriteLine("failed to get view of mapped file");
                return 1024;
            }
            try
            {
                if (WaitForSingleObject(mtx, INFINITE) == WAIT_FAILED)
                {
                    Console.WriteLine("mutex handle is invalid");
                    return 1025;
                }
                try
                {
                    GCMZDropsData d = new GCMZDropsData();
                    Marshal.PtrToStructure(mapped, d);

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
                            if (int.TryParse(endStr, out int end))
                            {
                                moveframe = end;    //一番上にあるend=値の値をmoveframeに代入してループから抜ける
                                break;
                            }
                        }
                    }
                    exopath = exopath.Replace(@"\", "\\\\\\\\");
                    var buf = Encoding.UTF8.GetBytes("{\"layer\":" + layer + ",\"frameAdvance\":" + moveframe + ",\"files\":[\"" + exopath + "\"]}\n");
                    var cds = new COPYDATASTRUCT
                    {
                        dwData = (IntPtr)1,
                        cbData = buf.Length,
                        lpData = Marshal.AllocHGlobal(buf.Length)
                    };
                    try
                    {
                        Marshal.Copy(buf, 0, cds.lpData, buf.Length);
                        SendMessage((IntPtr)d.Window, WM_COPYDATA, IntPtr.Zero, cds);
                    }
                    finally
                    {
                        Marshal.FreeHGlobal(cds.lpData);
                    }
                }
                finally
                {
                    ReleaseMutex(mtx);
                }
            }
            finally
            {
                UnmapViewOfFile(mapped);
            }
            return 0;
        }
    }
}
