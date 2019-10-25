namespace ConsoleChatSerializationTools
{
    using System.Net.Sockets;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Runtime.Serialization;

    /// <summary>
    /// This class is the serializer that is being used to serialize 
    /// and deserialize objects of type <see cref="IChatCommand"/>.
    /// </summary>
    public class ChatCommandSerializer
    {
        /// <summary>
        /// This field stores an instance of the <see cref="BinaryFormatter"/> class.
        /// It is used for object serialization and deserialization.
        /// </summary>
        private BinaryFormatter serializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCommandSerializer"/> class.
        /// </summary>
        public ChatCommandSerializer()
        {
            this.serializer = new BinaryFormatter();
        }

        /// <summary>
        /// This method serializes an object of type <see cref="IChatCommand"/>
        /// into a network stream.
        /// </summary>
        /// <param name="chatCommand">The <see cref="IChatCommand"/> that is to be serialized.</param>
        /// <param name="stream">The stream in which the object is being serialized into.</param>
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
                throw new SerializationException($"object in stream could not be deserialized into an object of type {typeof(IChatCommand)}");
            }

            return command;
        }
    }
}