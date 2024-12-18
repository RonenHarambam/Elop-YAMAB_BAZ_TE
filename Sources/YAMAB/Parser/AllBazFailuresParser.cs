using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YAMAB.InputItems;

namespace YAMAB.Parser
{
    class AllBazFailuresParser
    {
        public static void Parser(byte[] buffer, ref AllBazFailuresItem item)
        {
            int startIndex = StateMachineYAMAB.DATA_START_INDEX;

            item.m_numberOfFailures = Shared.m_ConversionsLittleEndian.UshortFromBytes(buffer, startIndex);
            startIndex += 2;

            item.M_errorNumber = Shared.m_ConversionsLittleEndian.UshortFromBytes(buffer, startIndex);
            startIndex += 2;
        }
    }
}
