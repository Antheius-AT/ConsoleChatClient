using ConsoleChatSerializationTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleChatClient
{
    /// <summary>
    /// This is the <see cref="TextCommand"/> class.
    /// It can be sent over the network to be executed by a chat partner.
    /// </summary>
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