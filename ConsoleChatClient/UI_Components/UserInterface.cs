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
        /// This stores a list of possible menu options.
        /// </summary>
        private List<ExecutableMenuOption> options;
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterface"/> class.
        /// </summary>
        public UserInterface(List<ExecutableMenuOption> options)
        {
            this.options = options;
        }

        public MenuNavigator MenuNavigator
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method presents the options the user can 
        /// choose from in a clear way.
        /// </summary>
        /// <param name="options">The list of options the user can choose from.</param>
        public void PresentMenuOptions(List<ExecutableMenuOption> options)
        {
            throw new System.NotImplementedException();
        }
    }
}