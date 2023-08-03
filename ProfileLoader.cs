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

            /*SerifProfile kariProfile = new SerifProfile();
            SerifProfile kari2Profile = new SerifProfile();

            kariProfile.Id = 255;
            kariProfile.ProfileName = "KARI";

            kari2Profile.Id = 254;
            kari2Profile.ProfileName = "KARI2";

            serifProfiles.Add(kariProfile);
            serifProfiles.Add(kari2Profile);*/
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
                //不具合対策のため今後ここにプロファイルが一個もない場合に仮プロファイルを生成するようにする
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
