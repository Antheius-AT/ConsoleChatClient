using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace ConsoleChatServer
{
    public class ChatClient
    {
        private TcpClient tcpClient;
        private Thread pollingThread;
        private PollingThreadArguments pollingThreadArguments;

        /// <summary>
        /// This event is raised whenever there is new data available that was read from the network stream.
        /// </summary>
        public event System.EventHandler<DataAvailableEventArgs> DataAvailable;
        /// <summary>
        /// This event is raised whenever the client disconnected, either
        /// voluntarily, or by accident.
        /// </summary>
        public event System.EventHandler<ClientDisconnectedEventArgs> Disconnected;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatClient"/> class.
        /// </summary>
        /// <param name="client">This variable holds a reference to the underlying tcp client.</param>
        public ChatClient(TcpClient client)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method sends data to the connected chat client.
        /// </summary>
        /// <param name="data"></param>
        public void SendData(byte[] data)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method maintains the connection by continuously polling for new data.
        /// </summary>
        public void MaintainClientConnection()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method polls for new data and returns true if data is available.
        /// </summary>
        /// <returns>A boolean indicating whether data is available or not.</returns>
        private bool PollForData()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method ends the connection and closes the tcp client.
        /// </summary>
        public void EndClientConnection()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method fires the <see cref="DataAvailable"/> event, whenever there is new data available, 
        /// that was being read from the network stream.
        /// </summary>
        /// <param name="data">The data that was read from the network stream.</param>
        protected void FireOnDataAvailable(byte[] data)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method fires the <see cref="Disconnected"/> event, whenever a client disconnects.
        /// </summary>
        protected void FireOnClientDisconnected()
        {
            throw new System.NotImplementedException();
        }
    }
}