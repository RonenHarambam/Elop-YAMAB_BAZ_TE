using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YAMAB.InputItems;

namespace YAMAB.Parser
{
    class BazFailuresUpdateParser
    {
        public static void Parser(byte[] buffer, ref BazFailuresUpdateItem item)
        {
            int startIndex = StateMachineYAMAB.DATA_START_INDEX;

            item.m_failureNumber = Shared.m_ConversionsLittleEndian.UshortFromBytes(buffer, startIndex);
            startIndex += 2;

            item.m_status = buffer[startIndex];
            startIndex += 1;
        }
    }
}
