using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class Team
    {
        public byte Teamid;
        public string Name;
        string Abbr;
        string Logo;

        public void Set(byte Teamid, string Name, string Abbr, string Logo)
        {
            this.Teamid = Teamid;
            this.Name = Name;
            this.Abbr = Abbr;
            this.Logo = Logo;
        }

        
        
    }
}
