using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ConsoleChatClient
{
    /// <summary>
    /// This class represents a chat client that is able
    /// to connect to a chat server and send and receive messages.
    /// </summary>
    public class ChatClient
    {
        /// <summary>
        /// This field stores an instance of the <see cref="MessageRelay"/> class.
        /// </summary>
        private MessageRelay messageRelay;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatClient"/> class.
        /// </summary>
        public ChatClient()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method is used to connect to a remote endpoint.
        /// </summary>
        /// <param name="ipAddress">The ip address of the remote end point.</param>
        /// <param name="port">The port that is being used for the connection.</param>
        public void Connect(IPAddress ipAddress, int port)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method is used to close an open connection.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Is thrown if..
        /// ..the client is not currently connected to a remote end point.
        /// </exception>
        public void Disconnect()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method is used to send an array of bytes to the connected end point.
        /// </summary>
        /// <param name="data">The data that is being sent.</param>
        /// <exception cref="InvalidOperationException">
        /// Is thrown if..
        /// ..client is not currently connected to a remote end point.
        /// </exception>
        public void SendData(byte[] data)
        {
            throw new System.NotImplementedException();
        }
    }
}