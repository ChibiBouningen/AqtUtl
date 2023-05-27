using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqT_Utl
{
    internal class ProfileLoader
    {
        public void Load(ref List<SerifProfile> serifProfiles)
        {
            serifProfiles = new List<SerifProfile>();

            SerifProfile kariProfile = new SerifProfile();
            SerifProfile kari2Profile = new SerifProfile();

            kariProfile.Id = 255;
            kariProfile.ProfileName = "KARI";

            kari2Profile.Id = 254;
            kari2Profile.ProfileName = "KARI2";

            serifProfiles.Add(kariProfile);
            serifProfiles.Add(kari2Profile);
        }

        public void Save()
        {

        }
    }
}
