using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAMAB.InputItems
{
    class BazFailuresUpdateItem : ResponseItemBase
    {
        public ushort m_failureNumber;
        public byte m_status;
    }
}
