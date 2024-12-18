using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace OrionTools
{
    public class StateMachineBase
    {
        #region NewDataEvent
        /// <summary>
        /// This arguent is sent as "e" argument when the NewDataEvents is thrown
        /// </summary>
        public class NewDataArg : EventArgs
        {
            private byte[] m_newData;
            protected long m_clientId;

            public NewDataArg(long clientId, byte[] newData)
            {
                m_newData = newData;
                m_clientId = clientId;
            }

            public byte[] NewData
            {
                get
                {
                    return m_newData;
                }
            }

            public long ClientId
            {
                get
                {
                    return m_clientId;
                }
            }
        }

        public delegate void NewDataEventHandler(object sender, NewDataArg e);

        /// <summary>
        /// The event is raised to report to the client about new data.
        /// </summary>
        public event NewDataEventHandler NewDataEvent;

        protected void OnNewData(NewDataArg e)
        {
            NewDataEvent(this, e);
        }

        #endregion

        protected long m_clientId; //Stores the id of the state machine's owner
        bool m_writeToLog = false;
        string m_logFilePath;
        StreamWriter m_streamWriter = null;

        public StateMachineBase(long clientId)
        {
            m_clientId = clientId;
            Init();
        }

        //Delegate to current state
        protected delegate void DelState(byte inByte);
        protected DelState m_currentState = null;
        protected List<byte> m_message=new List<byte>();

        public StateMachineBase()
        {
            Init();
        }

        protected void SetState(DelState func)
        {
            m_currentState = func;
        }

        protected virtual DelState InitState
        {
            get
            {
                return null;
            }
        }

        public void WriteToLog(bool write, string logFilePath)
        {
            m_writeToLog = write;
            m_logFilePath = logFilePath;

            if (m_writeToLog)
            {
                if (m_streamWriter == null)
                {
                    m_streamWriter = new StreamWriter(logFilePath);
                }
            }
            else
            {
                if (m_streamWriter != null)
                {
                    m_streamWriter.Close();
                    m_streamWriter.Dispose();
                    m_streamWriter = null;
                }
            }
        }

        /// <summary>
        /// Here you should reset your state machine.
        /// </summary>
        public virtual void Init()
        {
            m_message.Clear();
            m_currentState = InitState;
           
        }

        public virtual void Process(byte[] buff)
        {
            if (m_writeToLog)
            {
                WriteLog(buff);
            }
            for(int i=0;i<buff.Length;i++)
            {
                m_currentState(buff[i]);
            }
        }

        private void WriteLog(byte[] buff)
        {
            string strWrite=string.Empty;
            if (m_streamWriter != null)
            {
                strWrite +=  "(Total bytes:" + buff.Length + ")";
                strWrite += System.Environment.NewLine;
                strWrite += FormatBuffer2HexString(0, buff);
            }
        }

        private string FormatBuffer2HexString(int startIndex, byte[] buffer)
        {
            string retVal = null;

            for (int i = startIndex; i < buffer.Length; i++)
            {
                retVal += buffer[i].ToString("X2") + " ";
            }
            return retVal;
        }
    }
}
