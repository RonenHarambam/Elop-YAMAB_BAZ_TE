using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace YAMAB
{
    class TimeoutManager
    {
        DateTime m_dtWaitUntil;
        double m_timeOutMsec;

        public TimeoutManager(double timeOutMsec)
        {
            m_timeOutMsec = timeOutMsec;
        }

        public bool Timeout
        {
            get
            {
                return DateTime.Now>m_dtWaitUntil;
            }
        }

        public void Start()
        {
            m_dtWaitUntil = DateTime.Now.AddMilliseconds(m_timeOutMsec);
        }
    }
}
