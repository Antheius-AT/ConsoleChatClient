using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class MenuNavigationCommandDown : IMenuNavigationCommand
    {
        public int Execute(int currentIndex, int maximumIndex)
        {
            if (currentIndex == maximumIndex)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex++;
            }

            return currentIndex;
        }
    }
}