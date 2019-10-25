using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatClient
{
    public class MessageReceivedEventArgs
    {
        public MessageReceivedEventArgs()
        {
            throw new System.NotImplementedException();
        }

        public byte[] Message
        {
            get => default;
            set
            {
            }
        }
    }
}