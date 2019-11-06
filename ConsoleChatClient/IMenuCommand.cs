using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public interface IMenuCommand : IMenuVisitable
    {
        void Execute(params object[] parameters);
    }
}