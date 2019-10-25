using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class TextCommand : IChatCommand
    {
        public TextCommand(string text)
        {
            throw new System.NotImplementedException();
        }

        public string Text
        {
            get => default;
            set
            {
            }
        }

        public void Execute(object commandParameter)
        {
            throw new NotImplementedException();
        }
    }
}