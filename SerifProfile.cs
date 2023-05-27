using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqT_Utl
{
    internal class SerifProfile
    {
        public int Id { get; set; }
        public string ProfileName { get; set; }
        public string usePriset;
        public string exo;
        public int sort;
        public SerifProfile()
        {

        }

        public override string ToString()
        {
            return ProfileName;
        }
    }
}
