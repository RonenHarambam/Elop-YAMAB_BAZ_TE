using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrionTools;
namespace YAMABGUI
{
    class Shared
    {
        public static void HandleError(Exception ex, string msg)
        {
            MessageBoxDetailed.Display(Messages.Msg001, msg, ex.Message, MessageBoxDetailed.sevirities.error);
        }
    }
}
