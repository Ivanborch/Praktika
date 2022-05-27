using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class PositionName
    {
        int positionId;
        string Name;

        public void SetPositiomId(int positionId)
        { 
            this.positionId = positionId;
        }

        public void SetName(string Name)
        { 
            this.Name = Name; 
        }
        
    }
}
