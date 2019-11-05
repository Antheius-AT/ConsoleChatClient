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
            IMenuNavigationCommand navigationCommand;

            while (true)
            {
                this.UserInterface.PresentMenuOptions(this.MenuAdministrator.MenuOptions);
                navigationCommand = this.UserInterface.GenerateNavigationCommand();
                this.ExecuteNavigationCommand(navigationCommand);
            }
        }

        private List<ExecutableMenuOption> ParameterizeMenuOptions()
        {
            throw new System.NotImplementedException();
        }

        private void StartSessionCommand()
        {
            throw new System.NotImplementedException();
        }

        private void ConnectSessionCommand()
        {
            throw new System.NotImplementedException();
        }

        private void ExecuteNavigationCommand(IMenuNavigationCommand command)
        {
            command.Execute(this.MenuAdministrator.ActiveIndex, this.MenuAdministrator.MenuOptions.Count - 1);
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