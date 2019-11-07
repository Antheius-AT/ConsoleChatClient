using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    /// <summary>
    /// This class is responsible for displaying UI related information,
    /// such as menu options or messages to the end user.
    /// </summary>
    public class UserInterface
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterface"/> class.
        /// </summary>
        public UserInterface()
        {
        }

        /// <summary>
        /// This method presents the options the user can 
        /// choose from in a clear way.
        /// </summary>
        /// <param name="options">The list of options the user can choose from.</param>
        public void PresentMenuOptions(MenuAdministrator administrator)
        {
            for (int i = 0; i < administrator.Menu.Entries.Count; i++)
            {
                if (i == administrator.ActiveIndex)
                {
                    Console.SetCursorPosition(0, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(administrator.Menu.Entries[i].Name);
                    Console.ResetColor();
                    continue;
                }
                if (i == administrator.PreviousIndex)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine(administrator.Menu.Entries[i].Name);
                    continue;
                }
            }
        }

        public IMenuCommand GenerateNavigationCommand()
        {
            return MapToNavigationCommand(Console.ReadKey(true).Key);
        }

        /// <summary>
        /// This method maps user input to a console independent menu command that can be interpreted by the <see cref="MenuNavigator"/>
        /// </summary>
        private IMenuCommand MapToNavigationCommand(ConsoleKey inputKey)
        {
            switch (inputKey)
            {
                case ConsoleKey.DownArrow:
                    return new MenuNavigationCommandDown();
                case ConsoleKey.UpArrow:
                    return new MenuNavigationCommandUp();
                case ConsoleKey.Enter:
                    return new MenuSelectionCommand();
                default:
                    throw new ArgumentOutOfRangeException(nameof(inputKey), "Key could not be mapped to a direction");
            }
        }
    }
}