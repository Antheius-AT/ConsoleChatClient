using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public interface IMenuNavigationCommand
    {
        int Execute(int currentIndex, int maximumIndex);
    }
}