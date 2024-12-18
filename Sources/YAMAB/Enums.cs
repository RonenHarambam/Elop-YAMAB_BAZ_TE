using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAMAB
{
    class Enums
    {
        public enum Opcodes : ushort
        {
            // messages from YAMAB to ZABAD
            ALL_SENSORS = 0x11,
            ALL_BAZ_FAILURES = 0x7, 
            BAZ_FAILURES_UPDATE = 0x8,

            // messages from ZABAD to YAMAB
            SET_MAIN_SYSTEM_MODE = 0x7,
            SET_BAZ_PARAMETERS = 0xA,
            SET_DRIFT_MODE = 0x11,
            REQUEST_ERROR_TABLE = 0x5,
            ECHO=0x6
        }
    }
}
