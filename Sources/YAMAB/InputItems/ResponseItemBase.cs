using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAMAB.InputItems
{
    class ResponseItemBase
    {
        public bool answerReceieved = false;

        public virtual ResponseItemBase Clone()
        {
            return (ResponseItemBase)this.MemberwiseClone();
        }
    }
}
