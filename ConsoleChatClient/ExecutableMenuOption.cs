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
        private string name;
        private Action execute;

        public ExecutableMenuOption(string name, Action execute)
        {
            this.Name = name;
            this.execute = execute;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Value can not be null or an empty string");
                }

                this.name = value;
            }
        }

        public void Execute()
        {
            this.execute.Invoke();
        }
    }
}