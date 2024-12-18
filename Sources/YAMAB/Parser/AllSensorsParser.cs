using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YAMAB.InputItems;

namespace YAMAB.Parser
{
    class AllSensorsParser
    {
        public static void Parse(byte[] buffer, ref AllSensorsItem item)
        {
            int startIndex = StateMachineYAMAB.DATA_START_INDEX;

            item.m_bazMode = buffer[startIndex];
            startIndex += 1;

            item.m_traverseAngleGunnerMirror = Shared.m_ConversionsLittleEndian.FloatFromBytes(buffer, startIndex);
            item.m_traverseAngleGunnerMirror = -item.m_traverseAngleGunnerMirror;
            startIndex += 4;

            item.m_jackingAngleGunnerMirror = Shared.m_ConversionsLittleEndian.FloatFromBytes(buffer, startIndex);
            startIndex += 4;

            item.m_solonoidJacking = buffer[startIndex];
            startIndex += 1;

            item.m_solonoidTraverse = buffer[startIndex];
            startIndex += 1;

            item.m_sachiputResetValueTraverse = Shared.m_ConversionsLittleEndian.FloatFromBytes(buffer, startIndex);
            startIndex += 4;

            item.m_sachiputResetValueJacking = Shared.m_ConversionsLittleEndian.FloatFromBytes(buffer, startIndex);
            startIndex += 4;

            item.m_driftCalibrationStatus = buffer[startIndex];
        }
    }
}
