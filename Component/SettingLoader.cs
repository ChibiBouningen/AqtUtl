using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqT_Utl.Component
{
    internal class SettingLoader
    {
        public void Load()
        {
            string json;
            try
            {
                json = File.ReadAllText("setting.json");
            }
            catch (Exception ex)
            {
                Save();
                json = File.ReadAllText("setting.json");
            }

            SettingJson setting = JsonSerializer.Deserialize<SettingJson>(json);

            Properties.Settings.Default.output_folder = setting.output_folder;
            Properties.Settings.Default.jimakuCopy_startup = setting.jimakuCopy_startup;
            Properties.Settings.Default.fps_AviUtl = setting.fps_AviUtl;
            Properties.Settings.Default.useGCMZ = setting.useGCMZ;
            Properties.Settings.Default.TopMost = setting.TopMost;

            if (setting.last_version != Assembly.GetExecutingAssembly().GetName().Version)      //最後に起動したときのバージョンが今のバージョンと異なる場合に処理
            {
                VersionChangedConvert versionChangedConvert = new VersionChangedConvert(setting.last_version);
            }

            Properties.Settings.Default.Save();


        }

        public void Save()
        {
            SettingJson setting = new SettingJson();
            setting.last_version = Assembly.GetExecutingAssembly().GetName().Version;
            setting.output_folder = Properties.Settings.Default.output_folder;
            setting.jimakuCopy_startup = Properties.Settings.Default.jimakuCopy_startup;
            setting.fps_AviUtl = Properties.Settings.Default.fps_AviUtl;
            setting.useGCMZ = Properties.Settings.Default.useGCMZ;
            setting.TopMost = Properties.Settings.Default.TopMost;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(setting, options);
            File.WriteAllText("setting.json", json);


        }
    }

    public class SettingJson
    {
        public Version last_version { get; set; }
        public string output_folder { get; set; }
        public bool jimakuCopy_startup { get; set; }
        public int fps_AviUtl { get; set; }
        public bool useGCMZ { get; set; }
        public bool TopMost { get; set; }
    }
}
