using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class Country
    {
        String countryCode;
        String countryName;

         public void Set(String countryCode, String countryName)
        {
            this.countryCode = countryCode;
            this.countryName = countryName;
        }
    }
}
