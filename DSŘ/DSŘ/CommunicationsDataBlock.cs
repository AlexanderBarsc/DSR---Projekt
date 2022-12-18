using Sharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSŘ
{
    /// <summary>
    /// Represents the datablock for communication from PLC
    /// </summary>
    public class CommunicationsDataBlock
    {

        public CommunicationsDataBlock(int state, int clock, bool nightModeSwitch)
        {
            State = state;
            Clock = clock;
            NightModeSwitch = nightModeSwitch;
        }

        public int State { get;  }

        public bool NightModeSwitch { get; private set; }

        public int Clock { get; private set; }

       
    }
}
