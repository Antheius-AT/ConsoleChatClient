using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class ApplicationBase
    {
        public ApplicationBase()
        {
            // this.ChatClient = new ChatClient();
            this.UserInterface = new UserInterface();
            this.MenuAdministrator = new MenuAdministrator(this.PopulateMenuOptions());
        }

        public ChatClient ChatClient
        {
            get;
            private set;
        }

        public UserInterface UserInterface
        {
            get;
            private set;
        }

        public MenuAdministrator MenuAdministrator
        {
            get;
            private set;
        }

        public void StartApplication()
        {
            IMenuCommand navigationCommand;

            while (true) // Diese Bedingung gehört selbstverständlich noch verfeinert, ist nur zum testen.
            {
                this.UserInterface.PresentMenuOptions(this.MenuAdministrator);
                navigationCommand = this.UserInterface.GenerateNavigationCommand();
                navigationCommand.Execute(this.MenuAdministrator);
            }
        }

        private void StartSessionCommand()
        {
            throw new NotImplementedException();
        }

        private void ConnectSessionCommand()
        {
            throw new System.NotImplementedException();
        }

        private List<ExecutableMenuOption> PopulateMenuOptions()
        {
            return new List<ExecutableMenuOption>()
            {
                new ExecutableMenuOption("Start session", this.StartSessionCommand),
                new ExecutableMenuOption("Connect to session", this.ConnectSessionCommand)
            };
        }
    }
}