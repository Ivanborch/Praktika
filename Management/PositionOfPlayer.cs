using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class PositionOfPlayer
    {
        int PositionId;
        int PlayerId;

        public void SetPositionId(int PositionId)
        {
            this.PositionId = PositionId;
        }

        public void SetPlayerId(int PlayerId)
        { 
            this.PlayerId = PlayerId; 
        }
    }
}
