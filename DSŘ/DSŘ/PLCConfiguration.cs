using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSŘ
{
    /// <summary>
    /// Enums to better represent data from DB.
    /// </summary>
    public class PLCConfiguration
    {
        public enum State
        {
            GreenVerticalRedHorizontal,
            SwitchToGreenHorizontalFirst,
            SwitchToGreenHorizontalSecond,
            RedVerticalGreenHorizontal,
            SwitchToGreenVerticalFirst,
            SwitchToGreenVerticalSecond,
            NightModeOrangeOn,
            NightModeOrangeOff
        }

        public enum Clock
        {
            HZ1 = 0,
            HZ2,
            HZ2_5

        }

    }
}
