using System;
using System.Collections.Generic;

using System.Text;

namespace TcpLib
{
    abstract class CommManagerBase
    {
        public abstract void SendMessage(byte[] buffer);
    }
}
