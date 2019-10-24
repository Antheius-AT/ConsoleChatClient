using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChatServer
{
    public class DataAvailableEventArgs
    {
        public DataAvailableEventArgs(byte[] data)
        {
            throw new System.NotImplementedException();
        }

        public byte[] Data
        {
            get => default;
            set
            {
            }
        }
    }
}