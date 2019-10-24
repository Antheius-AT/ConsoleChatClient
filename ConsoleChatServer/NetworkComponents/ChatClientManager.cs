using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleChatServer
{
    public class ChatClientManager
    {
        private Thread pollingThread;

        public ChatClientManager()
        {
            throw new System.NotImplementedException();
        }

        public List<ChatClient> ConnectedChatClients
        {
            get => default;
            set
            {
            }
        }

        public void AddClient(ChatClient client)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveClient(ChatClient client)
        {
            throw new System.NotImplementedException();
        }

        private void MaintainClientConnection(ChatClient client)
        {
            throw new System.NotImplementedException();
        }
    }
}