using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;
using System.Windows.Forms;

namespace AqT_Utl
{
    internal class ProfileLoader
    {
        public void Load(ref List<SerifProfile> serifProfiles)
        {
            serifProfiles = new List<SerifProfile>();

            string json;
            try
            {
                json = File.ReadAllText("profile.json");
            }
            catch
            {
                Save(serifProfiles);
                json = File.ReadAllText("profile.json");
            }
            
            serifProfiles = JsonSerializer.Deserialize<List<SerifProfile>>(json);
            if (serifProfiles.Count == 0)
            {
                //不具合対策のため、プロファイルが一個もない場合に仮プロファイルを生成するようにする
                SerifProfile p = new SerifProfile();
                p.Id = 1;
                p.ProfileName = "ゆっくりれいむ";
                p.UsePreset = "れいむ";
                p.Exo = "";
                p.Sort = 0;
                p.Hosei=0;
                p.Jimaku = false;
                p.layer = 0;
                serifProfiles.Add(p);
            }
        }

        public void Save(List<SerifProfile> serifProfiles)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(serifProfiles, options);
            File.WriteAllText("profile.json", json);
        }
    }
}
