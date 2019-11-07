using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public interface IMenuCommand
    {
        void Execute(MenuAdministrator menu);
    }
}