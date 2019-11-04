using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    /// <summary>
    /// This class represents an executable menu option.
    /// It holds information needed to execute a command.
    /// </summary>
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