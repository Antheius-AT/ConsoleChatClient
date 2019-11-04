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
            throw new System.NotImplementedException();
        }

        public ChatClient ChatClient
        {
            get => default;
            set
            {
            }
        }

        public UserInterface UserInterface
        {
            get => default;
            set
            {
            }
        }

        public void StartApplication()
        {
            throw new System.NotImplementedException();
        }

        private List<ExecutableMenuOption> ParameterizeMenuOptions()
        {
            throw new System.NotImplementedException();
        }
    }
}