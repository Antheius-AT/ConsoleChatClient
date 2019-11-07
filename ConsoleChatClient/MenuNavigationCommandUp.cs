using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class MenuNavigationCommandUp : IMenuCommand
    {
        public void Execute(MenuAdministrator administrator)
        {
            if (administrator.ActiveIndex - 1 < 0)
            {
                administrator.ActiveIndex = administrator.Menu.Entries.Count - 1;
            }
            else
            {
                administrator.ActiveIndex--;
            }
        }
    }
}