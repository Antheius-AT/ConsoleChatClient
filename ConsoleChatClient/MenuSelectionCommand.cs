using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class MenuSelectionCommand : IMenuCommand
    {
        public void Execute(MenuAdministrator administrator)
        {
            administrator.Menu.Entries[administrator.ActiveIndex].Execute();
        }
    }
}