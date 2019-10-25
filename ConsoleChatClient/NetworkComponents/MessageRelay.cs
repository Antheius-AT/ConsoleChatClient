using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ConsoleChatClient
{
    public class MessageRelay
    {
        private TcpClient tcpClient;
        private Thread relayThread;
        private RelayThreadArguments relayThreadArguments;

        public event System.EventHandler<MessageReceivedEventArgs> MessageReceived;

        public MessageRelay()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void FireOnMessageReceived(byte[] message)
        {
            throw new System.NotImplementedException();
        }

        public void StartRelay(IPAddress ipAddress, int port)
        {
            throw new System.NotImplementedException();
        }

        public void StopRelay()
        {
            throw new System.NotImplementedException();
        }

        private void RelayIncomingMessages()
        {
            throw new System.NotImplementedException();
        }

        public void RelayOutgoingMessage(byte[] message)
        {
            throw new System.NotImplementedException();
        }
    }
}