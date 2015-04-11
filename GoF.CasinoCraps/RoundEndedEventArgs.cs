using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CasinoCraps
{
    public class RoundEndedEventArgs : EventArgs
    {
        public RoundEndedEventArgs(RoundResult result)
        {
            Result = result;
        }

        public RoundResult Result { get; private set; }
    }
}
