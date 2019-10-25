using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ConsoleChatSerializationTools
{
    public class ChatCommandSerializer
    {
        private BinaryFormatter serializer;

        public ChatCommandSerializer()
        {
            this.serializer = new BinaryFormatter();
        }

        public void Serialize(IChatCommand chatCommand, NetworkStream stream)
        {
            this.serializer.Serialize(stream, chatCommand);
        }

        /// <summary>
        /// This method deserializes the input stream, and tries to
        /// map the resulting object into an instance of <see cref="IChatCommand"/>.
        /// If the conversion is not successful, an exception of type <see cref="SerializationException"/>
        /// is thrown.
        /// </summary>
        /// <param name="stream">The input stream that is being read.</param>
        /// <returns>A chat command.</returns>
        /// <exception cref="SerializationException">
        /// This exception is thrown if..
        /// ..the deserialized object can not be mapped to an object of type <see cref="IChatCommand"/>.
        /// </exception>
        public IChatCommand Deserialize(NetworkStream stream)
        {
            IChatCommand command; 

            command = this.serializer.Deserialize(stream) as IChatCommand; 

            if (command == null)
            {
                throw new SerializationException($"object in stream could not be des}erialized into an object of type {typeof(IChatCommand)}");
            }

            return command;
        }
    }
}