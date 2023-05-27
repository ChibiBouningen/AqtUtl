using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqT_Utl
{
    public class SerifProfile
    {
        public int Id { get; set; }
        public string ProfileName { get; set; }
        public string UsePreset { get; set; }
        public string Exo { get; set; }
        public int Sort { get; set; }
        public bool Jimaku { get; set; }
        public SerifProfile()
        {

        }

        public override string ToString()
        {
            return ProfileName;
        }
    }
}
