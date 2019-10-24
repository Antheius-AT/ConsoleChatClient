namespace ConsoleChatServer
{
    using System;
    using System.Threading;
    using System.Net.Sockets;
    public class Server
    {
        /// <summary>
        /// This variable stores an instance of the <see cref="TcpListener"/> class, which is used to listen for incoming connections.
        /// </summary>
        private TcpListener tcpListener;
        /// <summary>
        /// This variable stores an instance of the <see cref="Thread"/> class, and is used to independently listen for incoming connections.
        /// </summary>
        private Thread serverListenerThread;
        /// <summary>
        /// This variable stores an instance of the <see cref="ServerThreadArguments"/> class, and can be used to start and stop the <see cref="serverListenerThread"/> thread.
        /// </summary>
        private ServerThreadArguments serverThreadArguments;
        /// <summary>
        /// This variable holds the array of bytes that is sent by the servers <see cref="SendUpdates(TimeSpan)"/> method.
        /// </summary>
        private byte[] buffer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        public Server()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets or sets an instance of the <see cref="ChatClientManager"/> class.
        /// </summary>
        public ChatClientManager ChatClientManager
        {
            get;
            private set;
        }

        /// <summary>
        /// This method starts the server.
        /// Once started it is able to accept incoming connections and send and receive data.
        /// </summary>
        public void Start()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method is used to stop the server. 
        /// Once stopped the server will no longer listen for incoming connections or be able to send and receive data.
        /// </summary>
        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method starts the listener to accept incoming connections.
        /// </summary>
        private void ListenForIncomingConnections()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method stops the listener to stop accepting incoming connections.
        /// </summary>
        private void StopListeningForIncomingConnections()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This method sends updates to all connected game clients in a fixed time interval.
        /// </summary>
        /// <param name="interval">The time interval that indicates after how much time the server pushes out updates.</param>
        private void SendUpdates(TimeSpan interval)
        {
            throw new System.NotImplementedException();
        }
    }
}