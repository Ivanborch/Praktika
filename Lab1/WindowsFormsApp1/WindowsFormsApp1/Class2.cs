using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Country
    {
        String coutnryCode;
        String countryName;

        public void setCountryCode(String countryCode)
        {
            this.coutnryCode = countryCode;
        }

        public void setCountryName(String countryName)
        {
            this.countryName = countryName;
        }

    }
    internal class Player
    {
        int Playerid;
        String Lastname;
        String Firstname;
        String Gender;
        float Height;
        float Weight;
        String ShirtNumber;

        public void setAll()
        {
            this.Playerid = Playerid;
        }
    }
}
