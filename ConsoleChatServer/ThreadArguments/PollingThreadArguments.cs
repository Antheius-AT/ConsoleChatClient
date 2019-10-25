using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatServer
{
    public class PollingThreadArguments
    {
        public PollingThreadArguments()
        {
            this.Exit = false;
        }
        public bool Exit
        {
            get;
            set;
        }
    }
}