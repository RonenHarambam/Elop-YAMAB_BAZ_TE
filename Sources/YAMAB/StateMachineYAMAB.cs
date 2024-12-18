using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrionTools;

namespace YAMAB
{
    class StateMachineYAMAB : StateMachineBase
    {
        public const byte ZABAD_ID = 0x01;
        public const byte YAMAB_ID = 0x47;
        private ushort m_currentMessageExpectedMsgLength;
        private ushort m_currnetMsgDataLength = 0;
        public const int DATA_START_INDEX = 5;

        protected override DelState InitState
        {
            get
            {
                return WaitForUnitCode;
            }
        }

        private void WaitForUnitCode(byte inByte)
        {
            if (!inByte.Equals(YAMAB_ID))
            {
                Init();
                m_currnetMsgDataLength = 0;
            }
            else
            {
                m_message.Add(inByte);
                m_currentState = WaitForOpcode1;
            }
        }

        private void WaitForOpcode1(byte inByte)
        {
            m_message.Add(inByte);
            m_currentState = WaitForOpcode2;
        }

        private void WaitForOpcode2(byte inByte)
        {
            m_message.Add(inByte);
            m_currentState = WaitForLength1;
        }

        private void WaitForLength1(byte inByte)
        {
            m_message.Add(inByte);
            m_currentState = WaitForLength2;
        }

        private void WaitForLength2(byte inByte)
        {
            byte[] dataLength;

            m_message.Add(inByte);

            dataLength = new byte[2];

            dataLength[0] = m_message[m_message.Count - 2];
            dataLength[1] = m_message[m_message.Count - 1];

            m_currentMessageExpectedMsgLength = Shared.m_ConversionsLittleEndian.UshortFromBytes(dataLength, 0);

            m_currentState = WaitForData;
        }

        private void WaitForData(byte inByte)
        {
            m_message.Add(inByte);
            m_currnetMsgDataLength++;

            if (m_currnetMsgDataLength >= m_currentMessageExpectedMsgLength) //All message has been accepted
            {
                OnNewData(new NewDataArg(0, m_message.ToArray()));
                m_currnetMsgDataLength = 0;
                Init();
            }
        }
    }
}
