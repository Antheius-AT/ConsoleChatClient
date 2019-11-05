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
        public void PresentMenuOptions(List<ExecutableMenuOption> options)
        {
            foreach (ExecutableMenuOption item in options)
            {
                Console.WriteLine(item.Name);
            }
        }

        public IMenuNavigationCommand GenerateNavigationCommand()
        {
            return MapToNavigationCommand(Console.ReadKey(true).Key);
        }

        /// <summary>
        /// This method maps user input to a console independent menu command that can be interpreted by the <see cref="MenuNavigator"/>
        /// </summary>
        private IMenuNavigationCommand MapToNavigationCommand(ConsoleKey inputKey)
        {
            switch (inputKey)
            {
                case ConsoleKey.DownArrow:
                    return new MenuNavigationCommandDown();
                case ConsoleKey.UpArrow:
                    return new MenuNavigationCommandUp();
                default:
                    throw new ArgumentOutOfRangeException(nameof(inputKey), "Key could not be mapped to a direction");
            }
        }
    }
}