using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class MenuNavigationCommandUp : IMenuNavigationCommand
    {
        public int Execute(int currentIndex, int maximumIndex)
        {
            if (currentIndex == 0)
            {
                currentIndex = maximumIndex;
            }
            else
            {
                currentIndex--;
            }

            return currentIndex;
        }
    }
}