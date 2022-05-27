using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class Player
    {
        public byte PlayerId;
        public String Name;
        public byte positionalId;
        String joinYear;
        double height;
        double weidth;
        public String dateBirth;
        String country;
        String gender;
        public byte Teamid;

        public void Set(byte PlayerId, String Name, byte positionalId, String joinYear, double height, double weigth, String dateBirth, String country, String gender, byte Teamid)
        {
            this.PlayerId = PlayerId;
            this.Name = Name;
            this.positionalId = positionalId;
            this.joinYear = joinYear;
            this.height = height;
            this.weidth = weigth;
            this.dateBirth = dateBirth;
            this.country = country;
            this.gender = gender;
            this.Teamid = Teamid;
        }

    }
}
