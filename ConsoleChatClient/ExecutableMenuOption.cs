using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class ExecutableMenuOption
    {
        private Action execute;

        public ExecutableMenuOption(Action execute)
        {
            throw new System.NotImplementedException();
        }

        public string Name
        {
            get;
            private set;
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}