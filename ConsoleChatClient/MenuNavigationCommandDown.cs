using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class MenuNavigationCommandDown : IMenuCommand
    {
        public void Execute(MenuAdministrator administrator)
        {
            if (administrator.ActiveIndex + 1 > administrator.Menu.Entries.Count - 1)
            {
                administrator.ActiveIndex = 0;
            }
            else
            {
                administrator.ActiveIndex++;
            }
        }
    }
}