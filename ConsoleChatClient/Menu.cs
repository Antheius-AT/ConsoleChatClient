using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class Menu
    {
        public Menu(List<ExecutableMenuOption> entries)
        {
            this.Entries = entries;
        }

        public List<ExecutableMenuOption> Entries
        {
            get;
            private set;
        }
    }
}